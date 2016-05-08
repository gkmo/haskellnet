using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeTree
{
    public class AtomicType : BasicType
    {
        private string _name;

        public AtomicType(IToken payload)
            : base(payload)
        {            

        }

        public string Name
        {
            get 
            {
                if (_name == null)
                {
                    _name = (Children[0] as CommonTree).Text;
                }

                return _name; 
            }
        }

        public string DotnetName
        {
            get
            {
                return (ModuleIdentifier != null ? ModuleIdentifier.ClassName + "." : "") + Name;
            }
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

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
