using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpArgumentUnit : FSharpExpressionUnit
    {
        private FSharpTypeUnit _type;

        public FSharpArgumentUnit(FSharpCompilationUnit parent, FSharpTypeUnit type)
            : base(parent)
        {
            _type = type;
        }

        public string Name { get; set; }

        public override FSharpTypeUnit ReturnType
        {
            get { return _type; }            
        }

        internal override void Write(FSharpWriter writer)
        {
            writer.Write(Name);
        }

        internal void UpdateType(FSharpTypeUnit type)
        {
            _type = type;
        }
    }
}
