using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeDefinitionTree
{
    public class NewType : TypeDefinition
    {
        public NewType(IToken payload)
            : base(payload)
        {
        }
    }
}
