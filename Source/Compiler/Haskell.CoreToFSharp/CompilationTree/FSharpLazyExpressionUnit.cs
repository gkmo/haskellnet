using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpLazyExpressionUnit : FSharpExpressionUnit
    {
        private FSharpGenericTypeUnit _type;
        private FSharpExpressionUnit _expression;

        public FSharpLazyExpressionUnit(FSharpCompilationUnit parent, FSharpExpressionUnit expression)
            : base(parent)
        {
            _expression = expression;
        }

        public override FSharpTypeUnit ReturnType
        {
            get 
            {
                if (_type == null)
                {
                    _type = new FSharpGenericTypeUnit();
                    _type.Types.Add(_expression.ReturnType);
                    _type.Name = "Lazy";
                }

                return _type;
            }
        }

        internal override void Write(FSharpWriter writer)
        {
            writer.Write("lazy (");

            _expression.Write(writer);

            writer.Write(")");
        }
    }
}
