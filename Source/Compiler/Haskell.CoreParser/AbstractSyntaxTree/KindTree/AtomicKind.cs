using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.KindTree
{
    public class AtomicKind : Node
    {
        public AtomicKind(IToken payload)
            : base(payload)
        {

        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            throw new NotImplementedException();
        }
    }
}
