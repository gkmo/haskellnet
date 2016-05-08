using System.Collections.Generic;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpApplicationExpressionUnit : FSharpExpressionUnit
    {
        private FSharpTypeUnit _expressionType;

        public FSharpApplicationExpressionUnit(FSharpCompilationUnit parent)
            : base(parent)
        {
            TypeArguments = new List<FSharpTypeUnit>();
            ValueArguments = new List<FSharpExpressionUnit>();
        }

        public List<FSharpTypeUnit> TypeArguments { get; private set; }

        public List<FSharpExpressionUnit> ValueArguments { get; private set; }

        public override FSharpTypeUnit ReturnType
        {
            get
            {
                if (_expressionType == null && Expression != null)
                {
                    _expressionType = Expression.ReturnType;

                    if (_expressionType is FSharpTypeReferenceUnit)
                    {
                        _expressionType = ((FSharpTypeReferenceUnit)_expressionType).RealType;
                    }

                    var functionType = _expressionType as FSharpFunctionTypeUnit;

                    for (var i = 0; i < ValueArguments.Count && functionType != null; i++)
                    {
                        _expressionType = functionType.NextType;
                        functionType = _expressionType as FSharpFunctionTypeUnit;
                    }
                }

                return _expressionType;
            }
        }

        public FSharpExpressionUnit Expression { get; set; }

        public bool IsConstructor
        {
            get { return Expression is FSharpConstructorExpressionUnit; }
        }

        public override bool IsPartial()
        {
            var type = Expression.ReturnType;
            var refType = type as FSharpTypeReferenceUnit;
            while (refType != null)
            {
                type = refType.RealType;
                refType = type as FSharpTypeReferenceUnit;
            }

            var funcType = type as FSharpFunctionTypeUnit;

            return funcType?.ArgumentsCount - ValueArguments.Count > 0;
        }

        internal override void Write(FSharpWriter writer)
        {
            var delimiter = string.Empty;

            writer.Write("(");

            Expression.Write(writer);

            if (!IsConstructor)
            {
                if (!Expression.InferTypes && TypeArguments.Count > 0)
                {
                    writer.Write("<");

                    for (var i = 0; i < TypeArguments.Count; i++)
                    {
                        TypeArguments[i].Write(writer);

                        if (i != TypeArguments.Count - 1)
                        {
                            writer.Write(", ");
                        }
                    }

                    writer.Write(">");
                }

                writer.Write(" ");

                delimiter = " ";
            }
            else
            {
                if (ValueArguments.Count > 0)
                {
                    if (ValueArguments.Count > 1)
                    {
                        writer.Write(" (");
                    }

                    delimiter = ", ";
                }
            }

            for (var i = 0; i < ValueArguments.Count; i++)
            {
                writer.Write("(");

                var argumentType = GetArgumentType(Expression.ReturnType, i);
                var valueType = ValueArguments[i].ReturnType;
                
                if (argumentType.IsLazy && !valueType.IsLazy)
                {
                    writer.Write("lazy ");
                }
                else if (!argumentType.IsLazy && valueType.IsLazy)
                {
                    writer.Write("(");
                }

                ValueArguments[i].Write(writer);

                if (!argumentType.IsLazy && valueType.IsLazy)
                {
                    writer.Write(").Force()");
                }

                writer.Write(")");

                if (i < ValueArguments.Count - 1)
                {                    
                    writer.Write(delimiter);
                }
            }

            if (IsConstructor && ValueArguments.Count > 1)
            {
                writer.Write(")");
            }

            writer.Write(")");
        }

        private FSharpTypeUnit GetArgumentType(FSharpTypeUnit type, int i)
        {
            var refType = type as FSharpTypeReferenceUnit;
            while (refType != null)
            {
                type = refType.RealType;
                refType = type as FSharpTypeReferenceUnit;
            }

            var functionType = type as FSharpFunctionTypeUnit;

            if (functionType != null)
            {
                if (i == 0)
                {
                    return functionType.BasicType;
                }

                return GetArgumentType(functionType.NextType, i - 1);
            }

            var genericType = (FSharpConstructorTypeUnit)type;

            return genericType.Arguments[i];
        }        
    }
}
