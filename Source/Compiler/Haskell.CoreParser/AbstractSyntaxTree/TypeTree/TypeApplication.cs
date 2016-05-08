using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeTree
{
    public class TypeApplication : BasicType
    {
        private List<AtomicType> _atomicTypes;

        public TypeApplication(IToken payload)
            : base(payload)
        {
        }

        public BasicType BasicType
        {
            get { return (BasicType)Children[0]; }
        }

        public IList<AtomicType> AtomicTypes
        {
            get 
            {
                if (_atomicTypes == null)
                {
                    _atomicTypes = new List<AtomicType>();

                    for (int i = 1; i < ChildCount; i++)
                    {
                        _atomicTypes.Add((AtomicType)Children[i]);
                    }
                }

                return _atomicTypes; 
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }

        public override string ToString()
        {
            return BasicType.ToString() + "<" + _atomicTypes.ToString() + ">";
        }
    }
}
