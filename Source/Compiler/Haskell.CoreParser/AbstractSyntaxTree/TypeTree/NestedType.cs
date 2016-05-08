using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeTree
{
    public class NestedType : AtomicType
    {
        private Type _nestedType;

        public NestedType(IToken payload)
            : base(payload)
        {            

        }

        public new Type Type
        {
            get
            {
                if (_nestedType == null)
                {
                    _nestedType = (Type) Children[0];
                }

                return _nestedType;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
