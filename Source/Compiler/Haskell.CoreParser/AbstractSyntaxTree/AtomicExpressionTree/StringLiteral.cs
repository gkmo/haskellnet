using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree
{
    public class StringLiteral : Literal<string>
    {
        public StringLiteral(IToken payload)
            : base(payload)
        {

        }

        public override string Value
        {
            get { return (Children[1] as CommonTree).Text; }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
