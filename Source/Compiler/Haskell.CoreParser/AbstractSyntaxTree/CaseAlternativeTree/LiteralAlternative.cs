using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.CaseAlternativeTree
{
    public class LiteralAlternative : CaseAlternative
    {
        public LiteralAlternative(IToken payload)
            : base(payload)
        {

        }

        public AtomicExpression Literal
        {
            get { return (AtomicExpression)Children[0]; }
        }

        public override Expression Expression
        {
            get { return (Expression)Children[1]; }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
