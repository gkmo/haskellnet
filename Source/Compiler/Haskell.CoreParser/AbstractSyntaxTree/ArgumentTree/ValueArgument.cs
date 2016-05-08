using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.ArgumentTree
{
    public class ValueArgument : Argument
    {
        public ValueArgument(IToken payload)
            : base(payload)
        {
            
        }

        public Expression Expression
        {
            get
            {
                return (Expression)Children[0];
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return this.Expression.Accept(visitor, o);
        }
    }
}
