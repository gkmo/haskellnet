using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.ValueDefinitionTree
{
    public class ValueDefinition : Node
    {
        private bool _isRecursive;

        public ValueDefinition(IToken payload)
            : this(payload, false)
        {
        }

        public ValueDefinition(IToken payload, bool isRecursive)
            : base(payload)
        {
            _isRecursive = isRecursive;
        }

        public bool IsRecursive
        {
            get
            {
                return _isRecursive;
            }
        }

        public Variable Variable
        {
            get { return Children[0] as Variable; }
        }

        public TypeTree.Type ValueType
        {
            get { return Children[1] as TypeTree.Type; }
        }

        public Expression Expression
        {
            get { return Children[2] as Expression; }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
