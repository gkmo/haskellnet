using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree
{
    public class Note : Expression
    {
        public Note(IToken payload)
            : base(payload)
        {
        }

        public string NoteText
        {
            get { return ((CommonTree)Children[0]).Text; }
        }

        public Expression Expression
        {
            get { return (Expression)Children[1]; }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
