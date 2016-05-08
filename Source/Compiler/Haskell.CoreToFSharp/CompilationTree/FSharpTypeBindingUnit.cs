using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpTypeBindingUnit : FSharpAtomicTypeUnit
    {
        public FSharpTypeBindingUnit(string name)            
        {            
            Name = name;
        }

        internal override void Write(FSharpWriter writer)
        {
            writer.Write("'{0}", Name);
        }
    }
}
