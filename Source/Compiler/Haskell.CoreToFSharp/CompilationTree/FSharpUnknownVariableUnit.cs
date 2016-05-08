using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpUnknownVariableUnit : FSharpExpressionUnit
    {
        private FSharpCompilationUnit _realUnit;

        public FSharpUnknownVariableUnit(FSharpCompilationUnit parent)
            : base(parent)
        {

        }

        public string Name { get; set; }

        public new string Module { get; set; }

        public new string Namespace { get; set; }

        public new string Assembly { get; set; }
        
        public override FSharpTypeUnit ReturnType
        {
            get 
            {
                return new FSharpTypeReferenceUnit(new GetFSharpType(GetRealFSharpType));
            }
        }

        private FSharpTypeUnit GetRealFSharpType()
        {
            return RealUnit.ReturnType;
        }

        public FSharpCompilationUnit RealUnit
        {
            get
            {
                if (_realUnit == null)
                {
                    _realUnit = FindUnit(Name, Module, Namespace, Assembly, new List<FSharpTypeUnit>(0));
                }

                if (_realUnit == null)
                {
                    throw new Exception(string.Format("[{0}] {1}.{2}.{3} not found", Assembly, Namespace, Module, Name));
                }

                return _realUnit;
            }            
        }

        internal override void Write(FSharpWriter writer)
        {
            if (RealUnit is FSharpUnknownVariableUnit)
            {
                throw new NotImplementedException();
            }

            // if (!string.IsNullOrEmpty(Namespace) && Namespace != writer.CurrentModule.Namespace)
            // {
            // writer.Write("{0}.", Namespace);                
            // }

            // if (!string.IsNullOrEmpty(Module) && Module != writer.CurrentModule.Name)
            // {
            // writer.Write("{0}.", Module);
            // }

            // writer.Write(Name);
            RealUnit.Write(writer);
        }
    }
}
