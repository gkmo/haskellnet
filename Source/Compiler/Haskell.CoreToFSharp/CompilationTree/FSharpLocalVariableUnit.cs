using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpLocalVariableUnit : FSharpExpressionUnit
    {
        private FSharpTypeUnit _type;

        public FSharpLocalVariableUnit(FSharpCompilationUnit parent, string name, FSharpTypeUnit type)
            : base(parent)
        {
            Name = name;
            _type = type;
        }

        public string Name { get; private set; }

        public override FSharpTypeUnit ReturnType
        {
            get { return _type; }
        }

        internal override void Write(FSharpWriter writer)
        {
            if (!string.IsNullOrEmpty(Namespace) && Namespace != writer.CurrentModule.Namespace)
            {
                writer.Write("{0}.", Namespace);
            }

            if (!string.IsNullOrEmpty(Module) && Module != writer.CurrentModule.Name)
            {
                writer.Write("{0}.", Module);
            }

            writer.Write(Name);
        }

    }
}
