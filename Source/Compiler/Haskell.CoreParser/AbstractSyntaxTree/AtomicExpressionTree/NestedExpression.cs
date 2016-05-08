using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree
{
    public class NestedExpression : AtomicExpression
    {
        public NestedExpression(IToken payload)
            : base(payload)
        {

        }

        public Expression Expression
        {
            get { return (Children[0] as Expression); }
        }       

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
