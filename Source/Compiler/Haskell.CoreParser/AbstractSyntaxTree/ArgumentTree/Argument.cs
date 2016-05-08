using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.ArgumentTree
{
    public abstract class Argument : Node
    {
        public Argument(IToken payload)
            : base(payload)
        {
            
        }   
    }
}
