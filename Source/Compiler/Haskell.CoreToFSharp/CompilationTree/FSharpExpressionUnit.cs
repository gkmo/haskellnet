using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public abstract class FSharpExpressionUnit : FSharpCompilationUnit
    {
        protected FSharpExpressionUnit(FSharpCompilationUnit parent)
            : base(parent)
        {
        }

        public bool InferTypes { get; set; }

        public virtual bool IsPartial()
        {
            var type = ReturnType;
            var refType = type as FSharpTypeReferenceUnit;
            while (refType != null)
            {
                type = refType.RealType;
                refType = type as FSharpTypeReferenceUnit;
            }

            return type is FSharpFunctionTypeUnit;
        }
    }
}
