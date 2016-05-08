using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpExternalVariableUnit : FSharpExpressionUnit
    {
        private FSharpTypeUnit _expressionType;

        public FSharpExternalVariableUnit(FSharpCompilationUnit parent)
            : base(parent)
        {

        }

        public string Name { get; set; }

        public MemberInfo Member { get; set; }

        public Type ExternalModule { get; set; }        

        public Assembly ExternalAssembly { get; set; }

        public List<FSharpTypeUnit> BindingTypes { get; set; }

        public override FSharpTypeUnit ReturnType
        {
            get
            {
                if (_expressionType == null)
                {
                    var method = Member as MethodInfo;
                    var property = Member as PropertyInfo;

                    if (method != null)
                    {
                        var parametersInfo = method.GetParameters();
                        var returnInfo = method.ReturnParameter;

                        if (parametersInfo.Length > 0)
                        {
                            _expressionType = ExternalModulesHelper.CreateFSharpFunctionType(parametersInfo, returnInfo, BindingTypes);
                        }
                        else
                        {
                            _expressionType = ExternalModulesHelper.CreateFSharpType(returnInfo.ParameterType, BindingTypes);
                        }
                    }
                    else if (property != null)
                    {
                        _expressionType = ExternalModulesHelper.CreateFSharpType(property.PropertyType);
                    }
                }

                return _expressionType;
            }            
        }

        public bool IsMissingBindings
        {
            get
            {
                var method = Member as MethodInfo;
                if (method != null && method.IsGenericMethod)
                {
                    return method.GetGenericArguments().Length > BindingTypes.Count;
                }

                return false;
            }
        }

        internal override void Write(FSharpWriter writer)
        {
            writer.Write("{0}.{1}.{2}", ExternalModule.Namespace, ExternalModule.Name, Member.Name);            
        }
    }
}
