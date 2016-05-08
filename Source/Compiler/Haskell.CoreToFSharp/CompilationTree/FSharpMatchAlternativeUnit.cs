using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public abstract class FSharpMatchAlternativeUnit : FSharpCompilationUnit
    {
        public FSharpMatchAlternativeUnit(FSharpMatchExpressionUnit parent)
            : base(parent)
        { 
        }

        public FSharpExpressionUnit Expression { get; set; }

        public override FSharpTypeUnit ReturnType
        {
            get { return Expression.ReturnType; }
        }
    }
}
