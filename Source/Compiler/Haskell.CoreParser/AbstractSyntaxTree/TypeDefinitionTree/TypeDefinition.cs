using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeDefinitionTree
{
    public class TypeDefinition : Node
    {
        public TypeDefinition(IToken payload)
            : base(payload)
        {
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            throw new NotImplementedException();
        }
    }
}
