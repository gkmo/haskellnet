using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.CaseAlternativeTree
{
    public abstract class CaseAlternative : Node
    {
        public CaseAlternative(IToken payload)
            : base(payload)
        {

        }

        public CaseExpression CaseExpression { get; set; }

        public int Index { get; set; }

        public bool IsLast
        {
            get
            {
                return Index == 0;
            }
        }

        public abstract Expression Expression { get; }
    }
}
