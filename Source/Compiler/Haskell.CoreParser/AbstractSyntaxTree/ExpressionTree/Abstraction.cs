using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.BinderTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree
{
    public class Abstraction : Expression
    {
        private IList<Binder> _binders;

        public Abstraction(IToken payload)
            : base(payload)
        {

        }

        public Expression Expression
        {
            get { return Children[0] as Expression; }
        }

        public IList<Binder> Binders
        {
            get
            {
                if (_binders == null)
                {
                    int valueBinders = 0;
                    int typeBinders = 0;

                    _binders = new List<Binder>(Children.Count - 1);

                    for (int i = 1; i < Children.Count; i++)
                    {
                        Binder binder = Children[i] as Binder;
                        if (binder is ValueBinder)
                        {
                            binder.Index = valueBinders++;
                        }
                        else
                        {
                            binder.Index = typeBinders++;
                        }

                        _binders.Add(binder);
                    }
                }

                return _binders;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
