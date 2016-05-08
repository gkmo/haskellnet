using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpCastExpressionUnit : FSharpExpressionUnit
    {
        private FSharpTypeUnit _type;

        public FSharpCastExpressionUnit(FSharpCompilationUnit parent, FSharpTypeUnit type)
            : base(parent)
        {
            _type = type;
        }

        public FSharpExpressionUnit Expression { get; set; }

        public override FSharpTypeUnit ReturnType
        {
            get { return _type; }
        }

        internal override void Write(FSharpWriter writer)
        {
            Expression.Write(writer);

            // writer.Write(" :?> ");
            // ReturnType.Write(writer);
            var externalVariable = Expression as FSharpExternalVariableUnit;
            if (externalVariable != null && externalVariable.IsMissingBindings)
            {
                writer.Write("<");
                ReturnType.Write(writer);
                writer.Write(">");

                var method = externalVariable.Member as MethodInfo;
                if (method != null && method.ReturnType.Name == "Lazy`1")
                {
                    writer.Write(".Force()");
                }
            }
        }
    }
}
