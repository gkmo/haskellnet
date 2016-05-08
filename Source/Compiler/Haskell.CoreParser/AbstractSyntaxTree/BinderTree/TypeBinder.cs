using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree.BinderTree
{
    public class TypeBinder : Binder
    {
        private string _typeVariable;

        public TypeBinder(IToken payload)
            : base(payload)
        {

        }

        public string TypeVariable
        {
            get 
            {
                if (_typeVariable == null)
                {
                    _typeVariable = StgPreProcessor.ProcessString(((CommonTree)Children[0]).Text); 
                }

                return _typeVariable;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
