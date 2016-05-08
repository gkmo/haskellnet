//===========================================================================
// Title: ICoreVisitor.
// Description: Contains the of the Core language visitor 
// Copyright © 2008 G.K.M Oliveira.
// Dept. of Computing Science, Federal University of Pernambuco, Brazil
// All Rights Reserved
//===========================================================================
// This software is provided free for educational use only. It may
// not be used for commercial purposes without the prior written permission
// of the authors.
//===========================================================================


using Haskell.CoreParser.AbstractSyntaxTree;
using Haskell.CoreParser.AbstractSyntaxTree.AtomicExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.BinderTree;
using Haskell.CoreParser.AbstractSyntaxTree.ExpressionTree;
using Haskell.CoreParser.AbstractSyntaxTree.TypeDefinitionTree;
using Haskell.CoreParser.AbstractSyntaxTree.TypeTree;
using Haskell.CoreParser.AbstractSyntaxTree.ValueDefinitionTree;
using Haskell.CoreParser.AbstractSyntaxTree.CaseAlternativeTree;
using Haskell.CoreParser.AbstractSyntaxTree.ArgumentTree;

namespace Haskell.CoreParser 
{
    public interface ICoreVisitor
    {
        object Visit(Module program, object o);        

        object Visit(ApplicationExpression applicationExpression, object o);

        object Visit(ValueDefinition valueDefinition, object o);

        object Visit(AtomicType type, object o);

        object Visit(TypeApplication type, object o);

        object Visit(TypeAbstraction type, object o);

        object Visit(NestedType type, object o);

        object Visit(ArrowTypeConstruction type, object o);

        object Visit(Abstraction abstraction, object o);

        object Visit(ValueBinder valueBinder, object o);

        object Visit(TypeBinder valueBinder, object o);        

        object Visit(Variable variable, object o);

        object Visit(IntegerLiteral variable, object o);

        object Visit(StringLiteral variable, object o);

        object Visit(AlgebraicType algebraicType, object o);

        object Visit(RationalLiteral rationalLiteral, object o);

        object Visit(CaseExpression caseExpression, object o);

        object Visit(ConstructorAlternative constructorAlternative, object o);

        object Visit(LiteralAlternative literalAlternative, object o);

        object Visit(DefaultAlternative defaultAlternative, object o);

        object Visit(LocalDefinition localDefinition, object o);

        object Visit(DataConstructor dataConstructor, object o);

        object Visit(ConstructorDefinition constructorDefinition, object o);

        object Visit(Note note, object o);

        object Visit(TypeArgument typeArgument, object o);

        object Visit(CharLiteral charLiteral, object o);

        object Visit(CastExpression castExpression, object o);

        object Visit(UnsafeCoercion unsafeCoercion, object o);

        object Visit(SymetricCoercion symetricCoercion, object o);

        object Visit(NestedExpression nestedExpression, object o);
    }
}
