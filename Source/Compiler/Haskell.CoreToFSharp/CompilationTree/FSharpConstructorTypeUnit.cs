using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpConstructorTypeUnit : FSharpTypeUnit
    {
        public FSharpConstructorTypeUnit()
        {
            Arguments = new List<FSharpTypeUnit>();
        }

        public List<FSharpTypeUnit> Arguments { get; private set; }

        public List<FSharpTypeUnit> BindingTypes { get; set; }

        internal override void Write(FSharpWriter writer)
        {
            if (string.IsNullOrEmpty(Namespace) || string.IsNullOrEmpty(Module))
            {
                writer.Write(Name);
            }
            else
            {
                writer.Write("{0}.{1}.{2}", Namespace, Module, Name);
            }

            for (var i = 0; i < BindingTypes.Count; i++)
            {
                if (i == 0)
                {
                    writer.Write("<");
                }

                BindingTypes[i].Write(writer);

                if (i < BindingTypes.Count - 1)
                {
                    writer.Write(", ");
                }
                else
                {
                    writer.Write(">");
                }
            }
        }
    }
}
