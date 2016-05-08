using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpFunctionTypeUnit : FSharpTypeUnit
    {
        public FSharpFunctionTypeUnit()
        {

        }

        public FSharpTypeUnit BasicType { get; set; }

        public FSharpTypeUnit NextType { get; set; }

        public int ArgumentsCount
        {
            get
            {
                var result = 1;

                var subType = NextType as FSharpFunctionTypeUnit;
                if (subType != null)
                {
                    result += subType.ArgumentsCount;
                }

                return result;
            }
        }

        internal override void Write(FSharpWriter writer)
        {
            BasicType.Write(writer);
            writer.Write(" -> ");
            NextType.Write(writer);
        }
    }
}
