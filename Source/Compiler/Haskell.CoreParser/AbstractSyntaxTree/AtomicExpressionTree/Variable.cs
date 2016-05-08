using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree
{
    public class Variable : AtomicExpression
    {
        public Variable(IToken payload)
            : base(payload)
        {

        }

        public string Name
        {
            get { return (Children[0] as CommonTree).Text; }
        }

        public ModuleIdentifier ModuleIdentifier
        {
            get
            {
                if (ChildCount >= 2)
                {
                    return Children[1] as ModuleIdentifier;
                }

                return null;
            }
        }

        public override bool Equals(object obj)
        {
            Variable other = obj as Variable;
            if (other == null)
            {
                return false;
            }

            return this.Name.Equals(other.Name) && this.ModuleIdentifier.Equals(other.ModuleIdentifier);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + (this.ModuleIdentifier != null ? this.ModuleIdentifier.GetHashCode() * 13 : 0);
        }

        public override string ToString()
        {
            string result = "";

            if (ModuleIdentifier != null)
            {
                result = ModuleIdentifier.Namespace + "." + ModuleIdentifier.ClassName + ".";
            }

            return result + Name;
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
