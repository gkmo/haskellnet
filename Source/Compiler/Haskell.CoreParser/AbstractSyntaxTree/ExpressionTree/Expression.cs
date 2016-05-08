using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree
{
    public abstract class Expression : Node
    {
        protected Expression(IToken payload)
            : base(payload)
        {
            
        }

        public bool Inline { get; set; }
    }
}
