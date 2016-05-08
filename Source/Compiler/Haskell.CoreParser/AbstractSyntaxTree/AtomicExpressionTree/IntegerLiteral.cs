using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree
{
    public class IntegerLiteral : Literal<int>
    {
        public IntegerLiteral(IToken payload)
            : base(payload)
        {

        }

        public override int Value
        {
            get 
            {
                try
                {
                    return Int32.Parse((Children[1] as CommonTree).Text); 
                }
                catch (OverflowException)
                {
                    return Int32.MaxValue;
                }                
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
