using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpLiteralAlternativeUnit : FSharpMatchAlternativeUnit
    {
        public FSharpLiteralAlternativeUnit(FSharpMatchExpressionUnit parent)
            : base(parent)
        {
        }

        public FSharpExpressionUnit Literal { get; set; }

        internal override void Write(FSharpWriter writer)
        {
            writer.Write("| ");
            Literal.Write(writer);
            writer.WriteLine("-> ");

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
