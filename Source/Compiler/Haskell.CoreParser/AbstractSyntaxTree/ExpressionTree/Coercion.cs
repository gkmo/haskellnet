using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree
{
    public abstract class Coercion : Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type
    {
        public Coercion(IToken payload)
            : base(payload)
        {

        }
    }
}
