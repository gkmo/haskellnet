using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeTree
{
    public abstract class BasicType : Type
    {
        protected BasicType(IToken payload)
            : base(payload)
        {

        }
    }
}
