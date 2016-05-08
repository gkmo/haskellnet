using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.BinderTree;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree.CaseAlternativeTree
{
    public class ConstructorAlternative : CaseAlternative
    {
        private IList<TypeBinder> _typeBinders;
        private IList<ValueBinder> _valueBinders;

        public ConstructorAlternative(IToken payload)
            : base(payload)
        {            
            
        }

        public DataConstructor DataConstructor
        {
            get
            {
                return (DataConstructor)Children[0];
            }
        }

        public override Expression Expression
        {
            get
            {
                return (Expression)Children[1];
            }
        }        

        public IList<TypeBinder> TypeBinders
        {
            get
            {
                if (_typeBinders == null)
                {
                    _typeBinders = new List<TypeBinder>();

                    for (int i = 2; i < ChildCount; i++)
                    {
                        TypeBinder item = Children[i] as TypeBinder;
                        if (item != null)
                        {
                            item.Index = _typeBinders.Count;
                            _typeBinders.Add(item);
                        }
                    }
                }

                return _typeBinders;
            }
        }

        public IList<ValueBinder> ValueBinders
        {
            get
            {
                if (_valueBinders == null)
                {
                    _valueBinders = new List<ValueBinder>();

                    for (int i = 2; i < ChildCount; i++)
                    {
                        ValueBinder item = Children[i] as ValueBinder;
                        if (item != null)
                        {
                            item.Index = _valueBinders.Count;
                            _valueBinders.Add(item);
                        }
                    }
                }

                return _valueBinders;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
