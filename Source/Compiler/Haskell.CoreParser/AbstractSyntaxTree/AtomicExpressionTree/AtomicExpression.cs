using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree
{
    public abstract class AtomicExpression : Expression
    {
        public AtomicExpression(IToken payload)
            : base(payload)
        {

        }        
    }
}
