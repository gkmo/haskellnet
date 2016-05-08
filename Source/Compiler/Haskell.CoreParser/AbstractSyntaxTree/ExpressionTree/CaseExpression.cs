using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.TypeTree;
using Haskell.CoreParser.AbstractSyntaxTree.BinderTree;
using Haskell.CoreParser.AbstractSyntaxTree.CaseAlternativeTree;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree
{
    public class CaseExpression : Expression
    {
        private Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type _returnType;
        private Expression _expression;
        private ValueBinder _binder;
        private IList<CaseAlternative> _alternatives;

        public CaseExpression(IToken payload)
            : base(payload)
        {

        }

        public Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type ReturnType
        {
            get
            {
                if (_returnType == null)
                {
                    _returnType = (Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type)Children[0];
                }

                return _returnType;
            }
        }

        public Expression Expression
        {
            get
            {
                if (_expression == null)
                {
                    _expression = (Expression)Children[1];
                }

                return _expression;
            }
        }

        public ValueBinder Binder
        {
            get
            {
                if (_binder == null)
                {
                    _binder = (ValueBinder)Children[2];
                }

                return _binder;
            }
        }

        public IList<CaseAlternative> Alternatives
        {
            get
            {
                if (_alternatives == null)
                {
                    _alternatives = new List<CaseAlternative>();

                    for (int i = ChildCount - 1; i > 2; i--)
                    {
                        CaseAlternative alternative = (CaseAlternative)Children[i];
                        alternative.CaseExpression = this;
                        alternative.Index = i - 3;
                        _alternatives.Add(alternative);
                    }
                }

                return _alternatives;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
