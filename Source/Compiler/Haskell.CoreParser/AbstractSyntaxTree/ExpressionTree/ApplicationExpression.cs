using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.ArgumentTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree
{
    public class ApplicationExpression : Expression
    {
        public ApplicationExpression(IToken payload)
            : base(payload)
        {
            
        }

        public AtomicExpression Expression
        {
            get
            {
                return (AtomicExpression) Children[0];
            }
        }

        public IList<Argument> Arguments
        {
            get
            {
                List<Argument> arguments = new List<Argument>(ChildCount - 1);
                for (int i = 1; i < ChildCount; i++)
                {
                    arguments.Add((Argument)Children[i]);
                }

                return arguments;
            }
        }

        public override string Text
        {
            get
            {
                return String.Format("ApplicationExpression({0})", Expression.Text);
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
