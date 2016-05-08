using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpTypeDeclarationUnit : FSharpCompilationUnit
    {
        public FSharpTypeDeclarationUnit(FSharpModuleUnit parent)
            : base(parent)
        {            
            TypeBindings = new List<FSharpTypeBindingUnit>();
            UnionCases = new List<FSharpUnionCaseUnit>();            
        }

        public string Name { get; set; }

        public List<FSharpTypeBindingUnit> TypeBindings { get; private set; }

        public List<FSharpUnionCaseUnit> UnionCases { get; private set; }

        public bool IsGeneric
        {
            get { return TypeBindings.Count > 0; }
        }

        public FSharpTypeBindingUnit GetTypeBinding(string name)
        {
            foreach (var item in TypeBindings)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }

            throw new KeyNotFoundException(name);
        }

        public override FSharpTypeUnit ReturnType
        {
            get { throw new NotImplementedException(); }
        }

        internal override void Write(FSharpWriter writer)
        {
            writer.Write("type {0}", Name);            

            if (TypeBindings.Count > 0)
            {
                writer.Write("<");

                for (var i = 0; i < TypeBindings.Count; i++)
                {
                    TypeBindings[i].Write(writer);

                    if (i < TypeBindings.Count - 1)
                    {
                        writer.Write(", ");
                    }                    
                }

                writer.Write(">");
            }

            writer.WriteLine(" = ");

            writer.Ident();
            foreach (var item in UnionCases)
            {
                item.Write(writer);
            }

            writer.Unident();
            writer.WriteLine();
        } 
    }
}
