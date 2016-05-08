using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpLiteralExpressionUnit<T> : FSharpExpressionUnit
    {
        public FSharpAtomicTypeUnit _expressionType;

        public FSharpLiteralExpressionUnit(FSharpCompilationUnit parent, T value, string text)
            : base(parent)
        {
            Value = value;
            Text = text;
        }

        public T Value { get; set; }

        public string Text { get; private set; }

        public override FSharpTypeUnit ReturnType
        {
            get
            {
                if (_expressionType == null)
                {
                    _expressionType = new FSharpAtomicTypeUnit();
                    _expressionType.Namespace = typeof(T).Namespace;
                    _expressionType.Name = typeof(T).Name;
                }

                return _expressionType;
            }
        }

        internal override void Write(FSharpWriter writer)
        {
            if (Value is Char)
            {
                writer.Write(Text);
            }
            else
            {
                writer.Write(Value.ToString());
            }
        }

        public override bool IsPartial()
        {
            return false;
        }
    }
}
