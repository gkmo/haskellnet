using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpConstructorExpressionUnit : FSharpExpressionUnit
    {
        private FSharpTypeUnit _type;

        public FSharpConstructorExpressionUnit(FSharpCompilationUnit parent)
            : base(parent)
        {
        }

        public virtual string Name { get; set; }

        public override string Module { get; set; }

        public override string Namespace { get; set; }

        public override string Assembly { get; set; }

        public virtual bool IsLazy { get; set; }

        public override FSharpTypeUnit ReturnType
        {
            get 
            {
                if (_type == null)
                {
                    var unit = Parent as FSharpUnionCaseUnit;
                    if (unit != null)
                    {
                        _type = unit.ReturnType;
                    }
                    else
                    {
                        _type = new FSharpAtomicTypeUnit();
                        _type.Assembly = Assembly;
                        _type.Namespace = Namespace;
                        _type.Name = Module;
                    }
                }

                return _type;
            }
        }

        internal override void Write(FSharpWriter writer)
        {
            var construction = Name;

            if (!string.IsNullOrEmpty(Namespace) && !string.IsNullOrEmpty(Module))
            {
                if (writer.CurrentModule.Namespace != Namespace
                    || writer.CurrentModule.Name != Module)
                {
                    construction = Namespace + "." + Module + "." + construction;
                }
            }

            if (construction == "GHC.Bool.True")
            {
                construction = "true";
            }
            else if (construction == "GHC.Bool.False")
            {
                construction = "false";
            }
            else if (construction == "GHC.Unit.Z0T")
            {
                construction = "()";
            }

            writer.Write("{0} ", construction);
        }
    }
}
