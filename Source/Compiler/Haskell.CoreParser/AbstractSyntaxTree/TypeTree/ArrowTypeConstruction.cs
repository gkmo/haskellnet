using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeTree
{
    public class ArrowTypeConstruction : Type
    {
        public ArrowTypeConstruction(IToken payload)
            : base(payload)
        {

        }

        public Type BasicType
        {
            get
            {
                return (Children[0] as Type);
            }
        }

        public new Type Type
        {
            get
            {
                return (Children[1] as Type);
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }

        public override string ToString()
        {
            return this.BasicType.ToString() + " -> " + this.Type.ToString();
        }
    }
}
