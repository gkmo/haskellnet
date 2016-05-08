using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.KindTree
{
    public class ArrowKind : Kind
    {
        public ArrowKind(IToken payload)
            : base(payload)
        {

        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            throw new NotImplementedException();
        }
    }
}
