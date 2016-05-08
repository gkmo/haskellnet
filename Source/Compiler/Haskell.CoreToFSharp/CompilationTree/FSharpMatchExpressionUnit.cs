using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpMatchExpressionUnit : FSharpExpressionUnit
    {
        private FSharpTypeUnit _type;

        public FSharpMatchExpressionUnit(FSharpCompilationUnit parent, FSharpTypeUnit type)
            : base(parent)
        {
            _type = type;

            Alternatives = new List<FSharpMatchAlternativeUnit>();
        }

        public FSharpExpressionUnit Expression { get; set; }

        public List<FSharpMatchAlternativeUnit> Alternatives { get; private set; }

        public override FSharpTypeUnit ReturnType
        {
            get { return _type; }
        }

        internal override void Write(FSharpWriter writer)
        {
            writer.Write("match ");

            Expression.Write(writer);

            if (Expression.ReturnType.IsLazy)
            {
                writer.Write(".Force()");
            }

            writer.WriteLine(" with");

            foreach (var item in Alternatives)
            {
                item.Write(writer);
            }
        }
    }
}
