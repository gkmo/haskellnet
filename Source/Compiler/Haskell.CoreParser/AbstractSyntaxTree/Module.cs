using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.TypeDefinitionTree;
using Haskell.CoreParser.AbstractSyntaxTree.ValueDefinitionTree;

namespace Haskell.CoreParser.AbstractSyntaxTree
{
    public class Module : Node
    {
        public Module(IToken payload)
            : base(payload)
        {
        }

        public ModuleIdentifier Name
        {
            get
            {
                return (ModuleIdentifier) Children[0];
            }
        }

        public IList<TypeDefinition> Types
        {
            get
            {
                List<TypeDefinition> result = new List<TypeDefinition>();

                for (int i = 1; i < ChildCount; i++)
                {
                    TypeDefinition item = Children[i] as TypeDefinition;
                    if (item != null)
                    {
                        result.Add(item);
                    }
                }

                return result;
            }
        }

        public IList<ValueDefinition> Values
        {
            get
            {
                List<ValueDefinition> result = new List<ValueDefinition>();

                for (int i = 1; i < ChildCount; i++)
                {
                    ValueDefinition item = Children[i] as ValueDefinition;
                    if (item != null)
                    {
                        result.Add(item);
                    }
                }

                return result;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
