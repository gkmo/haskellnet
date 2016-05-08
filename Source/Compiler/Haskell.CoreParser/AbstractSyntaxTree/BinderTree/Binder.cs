using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.BinderTree
{
    public abstract class Binder : Node
    {
        public Binder(IToken payload)
            : base(payload)
        {

        }

        public int Index { get; set; }
    }
}
