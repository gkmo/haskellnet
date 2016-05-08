using System.Collections.Generic;
using System.IO;

using Antlr.Runtime.Tree;

using Haskell.CoreParser;
using Haskell.CoreParser.AbstractSyntaxTree;
using Haskell.CoreParser.AbstractSyntaxTree.ArgumentTree;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.BinderTree;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.TypeTree;
using Haskell.CoreToFSharp.CompilationTree;
using Haskell.CoreParser.AbstractSyntaxTree.CaseAlternativeTree;
using Haskell.CoreParser.AbstractSyntaxTree.TypeDefinitionTree;
using Haskell.CoreParser.AbstractSyntaxTree.ValueDefinitionTree;

namespace Haskell.CoreToFSharp
{
    using System.Linq;

    public class CoreToFSharp : ICoreVisitor
    {
        public static void Convert(Module module, string resultFileName, bool isWinExe)
        {
            FSharpModuleUnit unit = null;

            try
            {
                unit = (FSharpModuleUnit)module.Accept(new CoreToFSharp(), null);
            }
            finally
            {
                if (unit != null)
                {
                    unit.IsWinExe = isWinExe;

                    var fs = new FileStream(resultFileName, FileMode.Create);
                    var writer = new StreamWriter(fs);
                    var fsWriter = new FSharpWriter();
                    unit.Write(fsWriter);
                    writer.Write(fsWriter.ToString());
                    writer.Close();
                    fs.Close();
                }
            }
        }

        #region ICoreVisitor Members

        public object Visit(Module program, object o)
        {
            var result = new FSharpModuleUnit
                             {
                                 Name = program.Name.ClassName,
                                 Namespace = program.Name.Namespace,
                                 Assembly = program.Name.AssemblyName
                             };


            foreach (var item in program.Types)
            {
                result.TypeDeclarations.Add((FSharpTypeDeclarationUnit)item.Accept(this, result));
            }

            foreach (var unit in program.Values.Select(item => (FSharpValueDeclarationUnit)item.Accept(this, result)))
            {
                if (unit.Name == "zcmain")
                {
                    result.HasEntryPoint = true;
                }

                result.ValueDeclarations.Add(unit);
            }

            for (var i = 0; i < result.ValueDeclarations.Count; i++)
            {
                var unit = result.ValueDeclarations[i];

                foreach (var item in unit.DependenciesNotFound)
                {
                    for (var j = i + 1; j < result.ValueDeclarations.Count; j++)
                    {
                        unit.IsRecursive = true;
                        result.ValueDeclarations[j].IsRecursiveObject = true;

                        if (result.ValueDeclarations[j].Name == item)
                        {
                            break;
                        }
                    }
                }
            }

            return result;
        }

        public object Visit(AlgebraicType algebraicType, object o)
        {
            var module = (FSharpModuleUnit)o;
            var result = new FSharpTypeDeclarationUnit(module) { Name = algebraicType.Name };

            foreach (var typeBinder in algebraicType.TypeBinders)
            {
                result.TypeBindings.Add(new FSharpTypeBindingUnit(typeBinder.TypeVariable));
            }

            foreach (var constructor in algebraicType.Constructors)
            {
                result.UnionCases.Add((FSharpUnionCaseUnit)constructor.Accept(this, result));
            }

            return result;
        }

        public object Visit(ConstructorDefinition constructorDefinition, object o)
        {
            var parent = (FSharpTypeDeclarationUnit)o;
            var result = new FSharpUnionCaseUnit(parent) { Name = constructorDefinition.Constructor.Name };

            foreach (var typeBinder in constructorDefinition.TypeBinders)
            {
                result.Types.Add(result.Parent.GetTypeBinding(typeBinder.TypeVariable));
            }

            foreach (var atomicType in constructorDefinition.AtomicTypes)
            {
                var type = (FSharpTypeUnit)atomicType.Accept(this, result);
                var lazyType = new FSharpGenericTypeUnit { Name = "Lazy" };
                lazyType.Types.Add(type);

                result.Types.Add(lazyType);
            }

            result.IsLazy = result.Types.Count > 0;

            return result;
        }

        public object Visit(ValueDefinition valueDefinition, object o)
        {
            var module = (FSharpModuleUnit)o;

            var result = new FSharpValueDeclarationUnit(module);

            var isEntryPoint = false;

            if (valueDefinition.Variable.ModuleIdentifier != null && valueDefinition.Variable.ModuleIdentifier.ClassName == ":Main")
            {
                result.Name = "zcmain";
                isEntryPoint = true;
            }
            else
            {
                result.Name = valueDefinition.Variable.Name;
            }

            var abstraction = valueDefinition.ValueType as TypeAbstraction;
            if (abstraction != null)
            {
                foreach (var binder in abstraction.TypeBindings)
                {
                    result.TypeBindings.Add((FSharpTypeBindingUnit)binder.Accept(this, result));
                }
            }

            result.ValueType = (FSharpTypeUnit)valueDefinition.ValueType.Accept(this, result);
            result.Expression = (FSharpExpressionUnit)valueDefinition.Expression.Accept(this, result);
            result.IsPrivate = valueDefinition.Variable.ModuleIdentifier == null;

            if (!isEntryPoint && 
                (result.Expression is FSharpApplicationExpressionUnit || result.Expression is FSharpExpressionUnit) && 
                (!(result.ValueType is FSharpFunctionTypeUnit) || result.Expression.ReturnType.IsLazy))
            {
                var lazyValueType = new FSharpGenericTypeUnit { Name = "Lazy" };
                lazyValueType.Types.Add(result.ValueType);
                
                result.ValueType = lazyValueType;
            }

            return result;
        }

        public object Visit(Note note, object o)
        {
            var parent = (FSharpValueDeclarationUnit)o;

            parent.IsInline = note.NoteText == "\"InlineMe\"";

            return note.Expression.Accept(this, o);
        }

        public object Visit(ApplicationExpression applicationExpression, object o)
        {
            var parent = (FSharpCompilationUnit)o;
            var result = new FSharpApplicationExpressionUnit(parent);
            
            foreach (var item in applicationExpression.Arguments)
            {
                if (item is TypeArgument)
                {
                    result.TypeArguments.Add((FSharpTypeUnit)item.Accept(this, result));
                }
                else
                {
                    result.ValueArguments.Add((FSharpExpressionUnit)item.Accept(this, result));
                }
            }

            result.Expression = (FSharpExpressionUnit)applicationExpression.Expression.Accept(this, result);

            return result;
        }

        public object Visit(AtomicType type, object o)
        {
            var result = new FSharpAtomicTypeUnit { Name = type.Name };

            if (type.ModuleIdentifier != null)
            {
                result.Module = type.ModuleIdentifier.ClassName;
                result.Namespace = type.ModuleIdentifier.Namespace;
                result.Assembly = type.ModuleIdentifier.AssemblyName;

                if (type.Name == "IO" && type.ModuleIdentifier.AssemblyName == "base")
                {
                    return new FSharpGenericTypeUnit() 
                    { 
                        Name = type.Name, 
                        Module = type.ModuleIdentifier.ClassName, 
                        Namespace = type.ModuleIdentifier.Namespace, 
                        Assembly = type.ModuleIdentifier.AssemblyName 
                    };
                }
            }
            else if (result.Name.Substring(0, 1).ToLower() == result.Name.Substring(0, 1))
            {
                result.Name = "'" + result.Name;
            }

            return result;
        }

        public object Visit(TypeApplication type, object o)
        {            
            var result = new FSharpGenericTypeUnit();

            var baseType = (FSharpTypeUnit)type.BasicType.Accept(this, result);

            result.Namespace = baseType.Namespace;
            result.Module = baseType.Module;
            result.Name = baseType.Name;

            foreach (var item in type.AtomicTypes)
            {
                result.Types.Add((FSharpTypeUnit)item.Accept(this, result));
            }

            return result;
        }

        public object Visit(TypeAbstraction type, object o)
        {
            var parent = (FSharpCompilationUnit)o;

            var t = (FSharpTypeUnit)type.Type.Accept(this, parent);

            // TODO: implement
            // throw new NotImplementedException();
            return t;
        }

        public object Visit(NestedType type, object o)
        {
            return type.Type.Accept(this, o);
        }

        public object Visit(ArrowTypeConstruction type, object o)
        {            
            var result = new FSharpFunctionTypeUnit();

            var basicType = (FSharpTypeUnit)type.BasicType.Accept(this, result);

            if (!basicType.IsPrimitive && basicType is FSharpGenericTypeUnit)
            {
                var basicTypeLazyWrapper = new FSharpGenericTypeUnit { Name = "Lazy" };
                basicTypeLazyWrapper.Types.Add(basicType);

                basicType = basicTypeLazyWrapper;
            }

            result.BasicType = basicType;
            result.BasicType.IsLazy = !basicType.IsPrimitive;

            result.NextType = (FSharpTypeUnit)type.Type.Accept(this, result);

            return result;
        }

        public object Visit(Abstraction abstraction, object o)
        {
            var parent = (FSharpCompilationUnit)o;

            var valueDeclaration = parent as FSharpValueDeclarationUnit;
            var result = valueDeclaration != null ? new FSharpLambdaExpressionUnit(parent, (FSharpFunctionTypeUnit)valueDeclaration.ValueType) : new FSharpLambdaExpressionUnit(parent);

            foreach (var argument in abstraction.Binders.OfType<ValueBinder>().Select(item => (FSharpArgumentUnit)item.Accept(this, result)))
            {
                // Non primitive Arguments are always Lazy
                if (!argument.ReturnType.IsPrimitive)
                {
                    var argumentType = new FSharpGenericTypeUnit { Name = "Lazy" };
                    argumentType.Types.Add(argument.ReturnType);

                    argument.UpdateType(argumentType);
                }

                result.Arguments.Add(argument);
            }

            result.Expression = (FSharpExpressionUnit)abstraction.Expression.Accept(this, result);

            return result;
        }

        public object Visit(ValueBinder valueBinder, object o)
        {
            var parent = (FSharpCompilationUnit)o;
            var name = valueBinder.Variable.Name;
            var type = (FSharpTypeUnit)valueBinder.BasicType.Accept(this, parent);

            return new FSharpArgumentUnit(parent, type) { Name = name };            
        }

        public object Visit(TypeBinder valueBinder, object o)
        {
            return new FSharpTypeBindingUnit(valueBinder.TypeVariable);
        }

        public object Visit(Variable variable, object o)
        {
            var parent = (FSharpCompilationUnit)o;

            var moduleName = variable.ModuleIdentifier?.ClassName;
            var namespaceName = variable.ModuleIdentifier?.Namespace;
            var assemblyName = variable.ModuleIdentifier?.AssemblyName;

            var bindingTypes = new List<FSharpTypeUnit>();
            var applicationUnit = parent as FSharpApplicationExpressionUnit;
            if (applicationUnit != null)
            {
                bindingTypes = applicationUnit.TypeArguments;
            }

            var result = parent.FindUnit(variable.Name, moduleName, namespaceName, assemblyName, bindingTypes);

            if (result == null)
            {
                var unknownVariable = new FSharpUnknownVariableUnit(parent)
                                          {
                                              Name = variable.Name,
                                              Module = moduleName,
                                              Namespace = namespaceName,
                                              Assembly = assemblyName
                                          };

                result = unknownVariable;
            }

            return result;
        }

        public object Visit(IntegerLiteral variable, object o)
        {
            return new FSharpLiteralExpressionUnit<int>((FSharpCompilationUnit)o, variable.Value, ((CommonTree)variable.Children[1]).Text);
        }

        public object Visit(StringLiteral variable, object o)
        {
            return new FSharpLiteralExpressionUnit<string>((FSharpCompilationUnit)o, variable.Value, ((CommonTree)variable.Children[1]).Text);
        }

        public object Visit(RationalLiteral variable, object o)
        {
            return new FSharpLiteralExpressionUnit<double>((FSharpCompilationUnit)o, variable.Value, ((CommonTree)variable.Children[1]).Text);
        }

        public object Visit(CharLiteral variable, object o)
        {
            return new FSharpLiteralExpressionUnit<char>((FSharpCompilationUnit)o, variable.Value, ((CommonTree)variable.Children[1]).Text);
        }

        public object Visit(CaseExpression caseExpression, object o)
        {
            var parent = (FSharpCompilationUnit)o;

            var binding = (FSharpArgumentUnit)caseExpression.Binder.Accept(this, parent);

            var letExpression = new FSharpLetExpressionUnit(parent, binding.ReturnType);
            
            var returnType = (FSharpTypeUnit)caseExpression.ReturnType.Accept(this, parent);

            var matchExpression = new FSharpMatchExpressionUnit(letExpression, returnType) { Expression = binding };

            letExpression.Name = binding.Name;
            letExpression.Expression = (FSharpExpressionUnit)caseExpression.Expression.Accept(this, letExpression);
            letExpression.Body = matchExpression;            

            binding.UpdateType(letExpression.Expression.ReturnType);

            foreach (var item in caseExpression.Alternatives)
            {
                matchExpression.Alternatives.Add((FSharpMatchAlternativeUnit)item.Accept(this, matchExpression));
            }

            return letExpression;
        }

        public object Visit(ConstructorAlternative constructorAlternative, object o)
        {
            var parent = (FSharpMatchExpressionUnit)o;
            var result = new FSharpConstructorAlternativeUnit(parent)
                             {
                                 Constructor =
                                     (FSharpConstructorExpressionUnit)
                                     constructorAlternative.DataConstructor
                                         .Accept(this, o)
                             };


            foreach (var arg in constructorAlternative.ValueBinders.Select(item => (FSharpArgumentUnit)item.Accept(this, result)))
            {
                if (!result.Constructor.Name.EndsWith("zh") 
                    && !result.Constructor.Name.EndsWith("Z2H") 
                    && !result.Constructor.Name.EndsWith("Z4H"))
                {
                    // Non primitive constructor arguments are always Lazy
                    var argumentType = new FSharpGenericTypeUnit { Name = "Lazy" };
                    argumentType.Types.Add(arg.ReturnType);

                    arg.UpdateType(argumentType);
                }

                result.ValueBinders.Add(arg);
            }

            result.Expression = (FSharpExpressionUnit)constructorAlternative.Expression.Accept(this, result);

            return result;
        }

        public object Visit(LiteralAlternative literalAlternative, object o)
        {
            var parent = (FSharpMatchExpressionUnit)o;
            var result = new FSharpLiteralAlternativeUnit(parent)
                             {
                                 Literal =
                                     (FSharpExpressionUnit)
                                     literalAlternative.Literal.Accept(this, o)
                             };

            result.Expression = (FSharpExpressionUnit)literalAlternative.Expression.Accept(this, result);

            return result;
        }

        public object Visit(DefaultAlternative defaultAlternative, object o)
        {
            var parent = (FSharpMatchExpressionUnit)o;
            var result = new FSharpDefaultAlternativeUnit(parent);

            result.Expression = (FSharpExpressionUnit)defaultAlternative.Expression.Accept(this, result);

            return result;
        }

        public object Visit(LocalDefinition localDefinition, object o)
        {
            var parent = (FSharpCompilationUnit)o;

            var type = (FSharpTypeUnit)localDefinition.ValueDefinitions[0].ValueType.Accept(this, parent);

            var result = new FSharpLetExpressionUnit(parent, type)
                             {
                                 Name = localDefinition.ValueDefinitions[0].Variable.Name
                             };

            var expression = (FSharpExpressionUnit)localDefinition.ValueDefinitions[0].Expression.Accept(this, result);
            
            // Recurrent functions
            result.Expression = expression;

            if (expression != null && !expression.IsPartial() && !expression.ReturnType.IsLazy && !expression.ReturnType.IsPrimitive)
            {
                expression = new FSharpLazyExpressionUnit(result, expression);
            }

            // Update with final type
            result.Expression = expression;

            var letExpression = result;

            for (var i = 1; i < localDefinition.ValueDefinitions.Count; i++)
            {
                var newType = (FSharpTypeUnit)localDefinition.ValueDefinitions[i].ValueType.Accept(this, parent);
                var newLetExpression = new FSharpLetExpressionUnit(letExpression, newType)
                                           {
                                               Name = localDefinition.ValueDefinitions[i].Variable.Name
                                           };

                expression = (FSharpExpressionUnit)localDefinition.ValueDefinitions[i].Expression.Accept(this, letExpression);
                
                if (!expression.ReturnType.IsLazy)
                {
                    expression = new FSharpLazyExpressionUnit(letExpression, expression);
                }

                newLetExpression.Expression = expression;

                letExpression.Body = newLetExpression;
                letExpression = newLetExpression;
            }

            letExpression.Body = (FSharpExpressionUnit)localDefinition.Expression.Accept(this, letExpression);

            return result;
        }

        public object Visit(DataConstructor dataConstructor, object o)
        {
            var parent = (FSharpCompilationUnit)o;

            var types = new List<FSharpTypeUnit>(0);
            var application = parent as FSharpApplicationExpressionUnit;
            if (application != null)
            {
                types = application.TypeArguments;
            }

            var moduleName = dataConstructor.ModuleIdentifier?.ClassName;
            var namespaceName = dataConstructor.ModuleIdentifier?.Namespace;
            var assemblyName = dataConstructor.ModuleIdentifier?.AssemblyName;

            var result = parent.FindUnit(dataConstructor.Name, moduleName, namespaceName, assemblyName, types);

            if (result == null)
            {
                var constructor = new FSharpConstructorExpressionUnit(parent)
                                      {
                                          Name = dataConstructor.Name,
                                          Module = dataConstructor.ModuleIdentifier?.ClassName,
                                          Namespace = dataConstructor.ModuleIdentifier?.Namespace,
                                          Assembly = dataConstructor.ModuleIdentifier?.AssemblyName
                                      };

                result = constructor;
            }

            return result;
        }

        public object Visit(TypeArgument typeArgument, object o)
        {
            return typeArgument.Expression.Accept(this, o);
        }

        public object Visit(CastExpression castExpression, object o)
        {
            var parent = (FSharpCompilationUnit)o;

            var type = (FSharpTypeUnit)castExpression.Coercion.Accept(this, o);
            var result = new FSharpCastExpressionUnit(parent, type);
            result.Expression = (FSharpExpressionUnit)castExpression.Expression.Accept(this, result);

            return result;
        }

        public object Visit(UnsafeCoercion unsafeCoercion, object o)
        {
            return unsafeCoercion.ToType.Accept(this, o);
        }

        public object Visit(SymetricCoercion symetricCoercion, object o)
        {
            return symetricCoercion.ToType.Accept(this, o);
        }

        #endregion

        #region ICoreVisitor Members

        public object Visit(NestedExpression nestedExpression, object o)
        {
            return nestedExpression.Expression.Accept(this, o);
        }

        #endregion
    }
}
