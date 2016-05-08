using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public delegate FSharpTypeUnit GetFSharpType();

    public class FSharpTypeReferenceUnit : FSharpTypeUnit
    {
        private FSharpCompilationUnit _unit;
        private GetFSharpType _delgate;

        public FSharpTypeReferenceUnit(FSharpCompilationUnit unit)
        {
            _unit = unit;
        }

        public FSharpTypeReferenceUnit(GetFSharpType getTypeDelegate)
        {
            _delgate = getTypeDelegate;
        }

        public FSharpTypeUnit RealType
        {
            get 
            {
                if (_unit != null)
                {
                    return _unit.ReturnType;
                }

                return _delgate();
            }            
        }

        public override bool IsLazy
        {
            get
            {
                return RealType.IsLazy;
            }
        
            set
            {
                RealType.IsLazy = value;
            }
        }

        internal override void Write(FSharpWriter writer)
        {
            RealType.Write(writer);
        }
    }
}
