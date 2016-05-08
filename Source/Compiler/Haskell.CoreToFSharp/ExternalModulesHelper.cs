using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

using Haskell.CoreToFSharp.CompilationTree;

using Microsoft.FSharp.Core;
using Microsoft.FSharp.Reflection;

namespace Haskell.CoreToFSharp
{
    using System.Linq;

    using GHC;

    internal class ExternalModulesHelper
    {
        private static readonly Dictionary<string, Assembly> _loadedAssemblies = new Dictionary<string, Assembly>();        
        private static readonly Dictionary<string, FSharpModuleUnit> _modules = new Dictionary<string, FSharpModuleUnit>();

        public static FSharpCompilationUnit FindUnit(string name, string moduleName, string namespaceName, string assemblyName, List<FSharpTypeUnit> bindingTypes)
        {
            var assembly = LoadAssembly(assemblyName);

            var type = assembly?.GetType(namespaceName + "." + moduleName);

            if (type != null && FSharpType.IsModule(type))
            {
                var module = GetModuleUnit(moduleName, namespaceName, assemblyName);

                var property = type.GetProperty(name);
                if (property != null)
                {
                    var reference = new FSharpExternalVariableUnit(module)
                                        {
                                            Name = name,
                                            Member = property,
                                            ExternalModule = type,
                                            ExternalAssembly = assembly
                                        };
                    return reference;
                }

                var method = type.GetMethod(name);
                if (method != null)
                {
                    bool inferTypes;
                    var reference = new FSharpExternalVariableUnit(module)
                                        {
                                            Name = name,
                                            Member = method,
                                            ExternalModule = type,
                                            ExternalAssembly = assembly,
                                            BindingTypes = GetBindingTypes(method, bindingTypes, out inferTypes),
                                            InferTypes = inferTypes
                                        };
                    return reference;
                }

                var nestedTypes = type.GetNestedTypes();
                foreach (var item in nestedTypes)
                {
                    if (!FSharpType.IsUnion(item, FSharpOption<BindingFlags>.None))
                    {
                        continue;
                    }

                    var unionCases = FSharpType.GetUnionCases(item, FSharpOption<BindingFlags>.None);

                    foreach (var unionCase in unionCases)
                    {
                        if (unionCase.Name == name)
                        {
                            var reference = new FSharpExternalConstructorExpressionUnit(module)
                                                {
                                                    UnionCase = unionCase,
                                                    Module = type,
                                                    Assembly = assembly,
                                                    BindingTypes = bindingTypes
                                                };
                            return reference;
                        }
                    }
                }                    
            }

            return null;
        }

        public static FSharpTypeUnit CreateFSharpFunctionType(ParameterInfo[] parametersInfo, ParameterInfo returnInfo, List<FSharpTypeUnit> bindingTypes)
        {
            var result = new FSharpFunctionTypeUnit();

            var temp = result;

            for (var i = 0; i < parametersInfo.Length; i++)
            {
                var arg = parametersInfo[i];

                temp.BasicType = CreateFSharpType(arg.ParameterType, bindingTypes);

                if (i < parametersInfo.Length - 1)
                {
                    var nextType = new FSharpFunctionTypeUnit();
                    temp.NextType = nextType;
                    temp = nextType;
                }
            }

            temp.NextType = CreateFSharpType(returnInfo.ParameterType, bindingTypes);

            return result;
        }

        public static FSharpTypeUnit CreateFSharpType(Type type)
        {
            return CreateFSharpType(type, null);
        }

        public static FSharpTypeUnit CreateFSharpType(Type type, List<FSharpTypeUnit> bindingTypes)
        {
            FSharpTypeUnit result;

            if (FSharpType.IsFunction(type))
            {
                var elements = FSharpType.GetFunctionElements(type);
                var functionType = new FSharpFunctionTypeUnit
                                       {
                                           BasicType = CreateFSharpType(elements.Item1, bindingTypes),
                                           NextType = CreateFSharpType(elements.Item2, bindingTypes)
                                       };
                result = functionType;
            }
            else if (type.IsGenericType)
            {
                var genericType = new FSharpGenericTypeUnit();
                var genericArguments = type.GetGenericArguments();

                for (var i = 0; i < genericArguments.Length; i++)
                {
                    if (genericArguments[i].IsGenericParameter)
                    {
                        if (genericArguments[i].GenericParameterPosition < bindingTypes.Count
                            && !(bindingTypes[genericArguments[i].GenericParameterPosition] is FSharpGenericTypeUnit))
                        {
                            genericType.Types.Add(bindingTypes[genericArguments[i].GenericParameterPosition]);
                        }
                        else
                        {
                            Debug.WriteLine(string.Format("Ignoring generic argument {0} of type {1}", i, type.Name));
                        }
                    }
                    else
                    {
                        genericType.Types.Add(CreateFSharpType(genericArguments[i], bindingTypes));
                    }
                }

                result = genericType;
                result.Name = type.Name.Replace(string.Format("`{0}", type.GetGenericArguments().Length), string.Empty);
            }
            else
            {
                if (type.IsGenericParameter && type.DeclaringMethod != null)
                {
                    return FindGenericParameterType(type, bindingTypes);
                }
                else
                {
                    result = new FSharpAtomicTypeUnit { Name = type.Name, IsPrimitive = type.IsPrimitive };
                }
            }

            result.Namespace = type.Namespace;

            if (type.IsNested)
            {
                if (type.ReflectedType != null)
                {
                    result.Module = type.ReflectedType.Name;
                }
            }

            return result;
        }

        private static List<FSharpTypeUnit> GetBindingTypes(MethodInfo method, List<FSharpTypeUnit> bindingTypes, out bool inferTypes)
        {
            var result = bindingTypes;

            inferTypes = false;

            if (method.ContainsGenericParameters)
            {
                var attributes = method.GetCustomAttributes(typeof(Prim.ImportantGenericArguments), false);

                if (attributes.Length > 0)
                {
                    inferTypes = true;
                    var objType = CreateFSharpType(typeof(object));
                    result = new List<FSharpTypeUnit>(method.GetGenericArguments().Length);
                    for (var i = 0; i < result.Capacity; i++)
                    {
                        result.Add(objType);
                    }

                    foreach (Prim.ImportantGenericArguments item in attributes)
                    {
                        var b = 0;
                        var positions = item.Positions.Split(',');

                        foreach (var p in from position in positions where !string.IsNullOrEmpty(position) select int.Parse(position))
                        {
                            result[p] = bindingTypes[b++];
                        }
                    }
                }
                else if (method.GetGenericArguments().Length != bindingTypes.Count)
                {
                    inferTypes = true;
                }
                else
                {
                    if (bindingTypes.OfType<FSharpGenericTypeUnit>().Any(generic => generic.Types.Count == 0))
                    {
                        inferTypes = true;
                    }
                }
            }

            return result;
        }

        private static FSharpTypeUnit FindGenericParameterType(Type type, IList<FSharpTypeUnit> bindingTypes)
        {
            if (type.DeclaringMethod != null)
            {
                var args = type.DeclaringMethod.GetGenericArguments();

                for (var i = 0; i < args.Length; i++)
                {
                    if (args[i] == type)
                    {
                        return bindingTypes[i];
                    }
                }
            }

            throw new Exception("Generic Type Not Found");
        }

        private static FSharpModuleUnit GetModuleUnit(string moduleName, string namespaceName, string assemblyName)
        {
            FSharpModuleUnit result;
            var fullName = namespaceName + "." + moduleName;

            if (!_modules.TryGetValue(fullName, out result))
            {
                result = new FSharpModuleUnit { Assembly = assemblyName, Namespace = namespaceName, Name = moduleName };

                _modules.Add(fullName, result);
            }

            return result;
        }

        private static Assembly LoadAssembly(string assemblyName)
        {
            Assembly result;

            if (!_loadedAssemblies.TryGetValue(assemblyName, out result))
            {
                result = Assembly.LoadFrom(assemblyName + ".dll");
                if (result != null)
                {
                    _loadedAssemblies.Add(assemblyName, result);
                }
            }

            return result;
        }
    }
}
