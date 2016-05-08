//===========================================================================
// Title: CoreTreeAdaptor.
// Description: Maps ANTLR constants to AST nodes 
// Copyright © 2008 G.K.M Oliveira.
// Dept. of Computing Science, Federal University of Pernambuco, Brazil
// All Rights Reserved
//===========================================================================
// This software is provided free for educational use only. It may
// not be used for commercial purposes without the prior written permission
// of the authors.
//===========================================================================

using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Haskell.CoreParser.AbstractSyntaxTree;
using Haskell.CoreParser.AbstractSyntaxTree.ArgumentTree;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.BinderTree;
using Haskell.CoreParser.AbstractSyntaxTree.CaseAlternativeTree;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.TypeDefinitionTree;
using Haskell.CoreParser.AbstractSyntaxTree.TypeTree;
using Haskell.CoreParser.AbstractSyntaxTree.ValueDefinitionTree;

namespace Haskell.CoreParser
{
    class CoreTreeAdaptor : CommonTreeAdaptor
    {        
        public override object Create(IToken payload)
        {
            if (payload != null)
            {
                switch (payload.Type)
                {
                    case CoreParser.TK_MODULE:
                        return new Module(payload);
                    case CoreParser.TK_VALUE_DEF:
                        return new ValueDefinition(payload);
                    case CoreParser.TK_REC_VALUE_DEF:
                        return new ValueDefinition(payload, true);
                    case CoreParser.TK_ALGEBRIC_TYPE:
                        return new AlgebraicType(payload);
                    case CoreParser.TK_NESTED_EXPRESSION:
                        return new NestedExpression(payload);
                    case CoreParser.TK_NEW_TYPE:
                        return new NewType(payload);
                    case CoreParser.TK_VARIABLE:
                        return new Variable(payload);
                    case CoreParser.TK_APPLICATION:
                        return new ApplicationExpression(payload);
                    case CoreParser.TK_ATOMIC_TYPE:
                        return new AtomicType(payload);
                    case CoreParser.TK_ARROW_TYPE_CONSTRUCTION:
                        return new ArrowTypeConstruction(payload);
                    case CoreParser.TK_TYPE_ABSTRACTION:
                        return new TypeAbstraction(payload);
                    case CoreParser.TK_MODULE_IDENTIFIER:
                        return new ModuleIdentifier(payload);
                    case CoreParser.TK_LIT_STRING:
                        return new StringLiteral(payload);
                    case CoreParser.TK_LIT_INTEGER:
                        return new IntegerLiteral(payload);
                    case CoreParser.TK_LIT_CHAR:
                        return new CharLiteral(payload);
                    case CoreParser.TK_LIT_RATIONAL:
                        return new RationalLiteral(payload);
                    case CoreParser.TK_TYPE_APPLICATION:
                        return new TypeApplication(payload);
                    case CoreParser.TK_NESTED_TYPE:
                        return new NestedType(payload);
                    case CoreParser.TK_VALUE_BINDER:
                        return new ValueBinder(payload);
                    case CoreParser.TK_TYPE_BINDER:
                        return new TypeBinder(payload);
                    case CoreParser.TK_CASE_EXPRESSION:
                        return new CaseExpression(payload);
                    case CoreParser.TK_DEFAULT_ALTERNATIVE:
                        return new DefaultAlternative(payload);
                    case CoreParser.TK_LITERAL_ALTERNATIVE:
                        return new LiteralAlternative(payload);
                    case CoreParser.TK_CONSTRUCTOR_ALTERNATIVE:
                        return new ConstructorAlternative(payload);
                    case CoreParser.TK_ABSTRACTION:
                        return new Abstraction(payload);
                    case CoreParser.TK_TYPE_ARG:
                        return new TypeArgument(payload);
                    case CoreParser.TK_VALUE_ARG:
                        return new ValueArgument(payload);
                    case CoreParser.TK_CONSTRUCTOR_DEF:
                        return new ConstructorDefinition(payload);
                    case CoreParser.TK_LOCAL_DEFINITION:
                        return new LocalDefinition(payload);
                    case CoreParser.TK_NOTE:
                        return new Note(payload);
                    case CoreParser.TK_DATA_CONSTRUCTOR:
                        return new DataConstructor(payload);
                    case CoreParser.TK_CAST:
                        return new CastExpression(payload);
                    case CoreParser.TK_SYMMETRIC_COERCION:
                        return new SymetricCoercion(payload);
                    case CoreParser.TK_UNSAFE_COERCION:
                        return new UnsafeCoercion(payload);
                    case CoreParser.LNAME:
                    case CoreParser.UNAME:
                    case CoreParser.INTLITERAL:
                    case CoreParser.STRINGLITERAL:
                    case CoreParser.CHARLITERAL:
                        return new CommonTree(payload);
                    default:
                        throw new ArgumentException();                   
                }
            }

            return base.Create(payload);
        }

    }
}
