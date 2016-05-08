using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime.Tree;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree
{
    public class RationalLiteral : Literal<double>
    {
        public RationalLiteral(IToken payload)
            : base(payload)
        {

        }

        public override double Value
        {
            get { return Double.Parse((Children[1] as CommonTree).Text); }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
