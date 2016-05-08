using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpDefaultAlternativeUnit : FSharpMatchAlternativeUnit
    {
        public FSharpDefaultAlternativeUnit(FSharpMatchExpressionUnit parent)
            : base (parent)
        {

        }

        internal override void Write(FSharpWriter writer)
        {
            writer.WriteLine("|_ -> ");            
            writer.Ident();

            if (Expression.ReturnType.IsLazy)
            {
                writer.Write("(");
            }

            Expression.Write(writer);

            if (Expression.ReturnType.IsLazy)
            {
                writer.Write(").Force()");
            }

            writer.Unident();
            writer.WriteLine();
        }
    }
}
