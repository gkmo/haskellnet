
using System.Collections.Generic;
using System.Text;
using Haskell.CoreParser.AbstractSyntaxTree.TypeTree;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.ArgumentTree
{
    public class TypeArgument : Argument
    {
        public TypeArgument(IToken payload)
            : base(payload)
        {
            
        }

        public AtomicType Expression
        {
            get
            {
                return (AtomicType)Children[0];
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
