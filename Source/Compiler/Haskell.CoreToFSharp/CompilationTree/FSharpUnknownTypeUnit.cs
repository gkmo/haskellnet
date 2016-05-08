using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpUnknownTypeUnit : FSharpTypeUnit
    {
        public FSharpUnknownTypeUnit()
            : base()
        {
        }

        internal override void Write(FSharpWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
