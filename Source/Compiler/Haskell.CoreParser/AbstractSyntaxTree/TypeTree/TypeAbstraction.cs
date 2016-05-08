using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.BinderTree;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeTree
{
    public class TypeAbstraction : Type
    {
        private List<TypeBinder> _typeBiders;

        public TypeAbstraction(IToken payload)
            : base(payload)
        {

        }

        public new Type Type
        {
            get
            {
                return Children[0] as Type;
            }
        }

        public IList<TypeBinder> TypeBindings
        {
            get
            {
                if (_typeBiders == null)
                {
                    _typeBiders = new List<TypeBinder>();

                    for (int i = 1; i < Children.Count; i++)
                    {
                        _typeBiders.Add((TypeBinder)Children[i]);
                    }
                }

                return _typeBiders;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
