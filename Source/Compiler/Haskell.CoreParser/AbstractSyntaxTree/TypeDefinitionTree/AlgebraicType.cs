//===========================================================================
// Title: AlgebraicType.
// Description: Contains the of the AlgebraicType AST node 
// Copyright © 2008 G.K.M Oliveira.
// Dept. of Computing Science, Federal University of Pernambuco, Brazil
// All Rights Reserved
//===========================================================================
// This software is provided free for educational use only. It may
// not be used for commercial purposes without the prior written permission
// of the authors.
//===========================================================================

using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Haskell.CoreParser.AbstractSyntaxTree.BinderTree;

namespace Haskell.CoreParser.AbstractSyntaxTree.TypeDefinitionTree
{
    public class AlgebraicType : TypeDefinition
    {
        private string _name;
        private ModuleIdentifier _moduleIdentifier;
        private List<TypeBinder> _typeBinders;
        private List<ConstructorDefinition> _constructors;

        public AlgebraicType(IToken payload)
            : base(payload)
        {
        }

        public string Name
        {
            get
            {
                if (_name == null)
                {
                    _name = ((CommonTree)Children[0]).Text;
                }

                return _name;
            }
        }

        public ModuleIdentifier ModuleIdentifier
        {
            get 
            {
                if (_moduleIdentifier == null)
                {
                    _moduleIdentifier = (ModuleIdentifier)Children[1];
                }

                return _moduleIdentifier; 
            }
        }

        public IList<TypeBinder> TypeBinders
        {
            get
            {
                if (_typeBinders == null)
                {
                    _typeBinders = new List<TypeBinder>();

                    for (int i = 2; i < ChildCount; i++)
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

        public IList<ConstructorDefinition> Constructors
        {
            get
            {
                if (_constructors == null)
                {
                    _constructors = new List<ConstructorDefinition>();

                    for (int i = 2; i < ChildCount; i++)
                    {
                        ConstructorDefinition constructor = Children[i] as ConstructorDefinition;
                        if (constructor != null)
                        {
                            _constructors.Add(constructor);
                        }
                    }
                }

                return _constructors;
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return visitor.Visit(this, o);
        }
    }
}
