using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeTree
{
    public abstract class Type : Node
    {
        public Type(IToken payload)
            : base(payload)
        {

        }        
    }
}
