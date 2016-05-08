using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree
{
    public class UnsafeCoercion : Coercion
    {
        public UnsafeCoercion(IToken payload)
            : base(payload)
        {

        }

        public Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type FromType
        {
            get
            {
                return (Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type)Children[0];
            }
        }

        public Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type ToType
        {
            get
            {
                return (Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type)Children[1];
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
