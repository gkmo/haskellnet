using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpAtomicTypeUnit : FSharpTypeUnit
    {
        public FSharpAtomicTypeUnit()
        {

        }           

        internal override void Write(FSharpWriter writer)
        {
            if (IsLazy)
            {
                writer.Write("Lazy<");
            }

            if (!string.IsNullOrEmpty(Namespace) && Namespace != writer.CurrentModule.Namespace)
            {
                writer.Write("{0}.", Namespace);
            }

            if (!string.IsNullOrEmpty(Module) && Module != writer.CurrentModule.Name)
            {
                writer.Write("{0}.", Module);
            }

            writer.Write(Name);

            if (IsLazy)
            {
                writer.Write(">");
            }
        }
    }
}
