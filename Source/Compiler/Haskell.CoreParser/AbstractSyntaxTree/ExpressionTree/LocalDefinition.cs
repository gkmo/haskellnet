using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.ValueDefinitionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree
{
    public class LocalDefinition : Expression
    {
        private List<ValueDefinition> _valueDefinitions;

        public LocalDefinition(IToken payload)
            : base(payload)
        {

        }

        public IList<ValueDefinition> ValueDefinitions
        {
            get
            {
                if (_valueDefinitions == null)
                {
                    _valueDefinitions = new List<ValueDefinition>(ChildCount - 1);

                    for (int i = 0; i < ChildCount - 1; i++)
                    {
                        _valueDefinitions.Add((ValueDefinition)Children[i]);
                    }
                }

                return _valueDefinitions;
            }
        }

        public Expression Expression
        {
            get
            {
                return (Expression)Children[ChildCount - 1];
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
