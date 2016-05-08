using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime.Tree;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree
{
    public class CharLiteral : Literal<char>
    {
        public CharLiteral(IToken payload)
            : base(payload)
        {

        }

        public override char Value
        {
            get 
            {
                char result;

                string text = (Children[1] as CommonTree).Text.Replace("'", "");
                if (!char.TryParse(text, out result))
                {
                    text = text.Replace("\\x", "");
                    result = Convert.ToChar(int.Parse(text, System.Globalization.NumberStyles.HexNumber));
                }

                return result;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
