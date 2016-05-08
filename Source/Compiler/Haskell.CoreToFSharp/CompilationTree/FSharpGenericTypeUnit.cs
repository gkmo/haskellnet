using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpGenericTypeUnit : FSharpTypeUnit
    {
        public FSharpGenericTypeUnit()
        {
            Types = new List<FSharpTypeUnit>();
        }       

        public List<FSharpTypeUnit> Types { get; private set; }

        public override bool IsLazy
        {
            get
            {
                return Name == "Lazy";
            }
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

            if (Types.Count > 0)
            {
                writer.Write("<");

                for (var i = 0; i < Types.Count; i++)
                {
                    Types[i].Write(writer);

                    if (i < Types.Count - 1)
                    {
                        writer.Write(", ");
                    }
                }

                writer.Write(">");
            }
        }
    }
}
