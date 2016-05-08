using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.CaseAlternativeTree
{
    public class DefaultAlternative : CaseAlternative
    {
        public DefaultAlternative(IToken payload)
            : base(payload)
        {

        }

        public override Expression Expression
        {
            get { return (Expression)Children[0]; }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
