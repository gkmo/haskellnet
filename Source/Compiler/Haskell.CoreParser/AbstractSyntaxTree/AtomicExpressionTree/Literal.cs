using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree
{
    public abstract class Literal<T> : AtomicExpression
    {
        protected Literal(IToken payload)
            : base(payload)
        {
            
        }

        public abstract T Value { get; }

        public override string Text
        {
            get
            {
                return String.Format("{0} ({1})", typeof(T).Name, Value.ToString());
            }
        }
    }
}
