using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.TypeTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.BinderTree
{
    public class ValueBinder : Binder
    {
        public ValueBinder(IToken payload)
            : base(payload)
        {

        }

        
        public Variable Variable
        {
            get
            {
                return (Variable)Children[0];
            }
        }

        public Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type BasicType
        {
            get
            {
                return (Haskell.CoreParser.AbstractSyntaxTree.TypeTree.Type)Children[1];
            }
        }

        public override string ToString()
        {
            return Variable.ToString() + "::" + BasicType.ToString();
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
