using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Microsoft.FSharp.Reflection;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpExternalConstructorExpressionUnit : FSharpConstructorExpressionUnit
    {
        private FSharpConstructorTypeUnit _expressionType;

        public FSharpExternalConstructorExpressionUnit(FSharpCompilationUnit parent)
            : base(parent)
        {
        }

        public override string Name
        {
            get
            {
                return UnionCase.Name;
            }

            set
            {
                
            }
        }

        public UnionCaseInfo UnionCase { get; set; }

        public new Type Module { get; set; }        

        public new Assembly Assembly { get; set; }

        public List<FSharpTypeUnit> BindingTypes { get; set; }

        public override FSharpTypeUnit ReturnType
        {
            get
            {
                if (_expressionType == null)
                {
                    _expressionType = new FSharpConstructorTypeUnit();
                    _expressionType.Namespace = Module.Namespace;
                    _expressionType.Module = Module.Name;

                    if (UnionCase.DeclaringType.IsGenericType)
                    {
                        _expressionType.Name = UnionCase.DeclaringType.Name.Replace(string.Format("`{0}", UnionCase.DeclaringType.GetGenericArguments().Length), string.Empty);
                    }
                    else
                    {
                        _expressionType.Name = UnionCase.DeclaringType.Name;
                    }
                    
                    _expressionType.BindingTypes = BindingTypes;

                    var arguments = UnionCase.GetFields();
                    foreach (var item in arguments)
                    {
                        _expressionType.Arguments.Add(ExternalModulesHelper.CreateFSharpType(item.PropertyType, BindingTypes));
                    }                    
                }

                return _expressionType;
            }
        }

        public override bool IsLazy 
        {
            get
            {
                return false;
            }

            set { }
        }

        internal override void Write(FSharpWriter writer)
        {            
            writer.Write("{0}.{1}.{2} ", Module.Namespace, Module.Name, UnionCase.Name);
        }
    }
}
