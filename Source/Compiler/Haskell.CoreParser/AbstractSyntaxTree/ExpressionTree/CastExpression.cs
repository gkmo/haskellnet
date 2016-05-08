using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree
{
    public class CastExpression : Expression
    {
        private Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type _coercion;
        private Expression _expression;

        public CastExpression(IToken payload)
            : base(payload)
        {

        }

        public Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type Coercion
        {
            get
            {
                if (_coercion == null)
                {
                    _coercion = (Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type)Children[1];
                }

                return _coercion;
            }
        }

        public Expression Expression
        {
            get
            {
                if (_expression == null)
                {
                    _expression = (Expression)Children[0];
                }

                return _expression;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
