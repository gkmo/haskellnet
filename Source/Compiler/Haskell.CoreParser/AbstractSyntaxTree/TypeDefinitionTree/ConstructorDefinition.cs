using System.Collections.Generic;
using Antlr.Runtime;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.BinderTree;
using Haskell.CoreParser.AbstractSyntaxTree.TypeTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeDefinitionTree
{
    public class ConstructorDefinition : Node
    {
        private List<TypeBinder> _typeBinders;
        private List<AtomicType> _atomicTypes;

        public ConstructorDefinition(IToken payload)
            : base(payload)
        {
        }

        public DataConstructor Constructor
        {
            get
            {
                return (DataConstructor)Children[0];
            }
        }

        public IList<TypeBinder> TypeBinders
        {
            get
            {
                if (_typeBinders == null)
                {
                    _typeBinders = new List<TypeBinder>();

                    for (int i = 1; i < ChildCount; i++)
                    {
                        TypeBinder binder = Children[i] as TypeBinder;
                        if (binder != null)
                        {
                            _typeBinders.Add(binder);
                        }
                    }
                }

                return _typeBinders;
            }
        }

        public IList<AtomicType> AtomicTypes
        {
            get
            {
                if (_atomicTypes == null)
                {
                    _atomicTypes = new List<AtomicType>();

                    for (int i = 1; i < ChildCount; i++)
                    {
                        AtomicType type = Children[i] as AtomicType;
                        if (type != null)
                        {
                            _atomicTypes.Add(type);
                        }
                    }
                }

                return _atomicTypes;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
