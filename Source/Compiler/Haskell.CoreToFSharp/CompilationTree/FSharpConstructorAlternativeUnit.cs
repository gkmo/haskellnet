using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpConstructorAlternativeUnit : FSharpMatchAlternativeUnit
    {
        public FSharpConstructorAlternativeUnit(FSharpMatchExpressionUnit parent)
            : base(parent)
        {
            ValueBinders = new List<FSharpArgumentUnit>();
        }

        public FSharpConstructorExpressionUnit Constructor { get; set; }

        public List<FSharpArgumentUnit> ValueBinders { get; private set;}

        public override FSharpCompilationUnit FindUnit(string name, string moduleName, string namespaceName, string assemblyName, List<FSharpTypeUnit> bindingTypes)
        {
            if (string.IsNullOrEmpty(assemblyName) || assemblyName == Assembly)
            {
                if (string.IsNullOrEmpty(namespaceName) || namespaceName == Namespace)
                {
                    if (string.IsNullOrEmpty(moduleName) || moduleName == Module)
                    {
                        foreach (var item in ValueBinders)
                        {
                            if (item.Name == name)
                            {
                                return item;
                            }
                        }
                    }
                }
            }

            return base.FindUnit(name, moduleName, namespaceName, assemblyName, bindingTypes);
        }

        internal override void Write(FSharpWriter writer)
        {
            writer.Write("| ");

            Constructor.Write(writer);
            
            if (ValueBinders.Count > 0)
            {
                writer.Write("(");

                for (var i = 0; i < ValueBinders.Count; i++)
                {
                    ValueBinders[i].Write(writer);                    

                    if (i < ValueBinders.Count - 1)
                    {
                        writer.Write(", ");
                    }
                }

                writer.Write(") ");
            }

            writer.WriteLine("-> ");
            
            writer.Ident();

            if (Expression.ReturnType.IsLazy)
            {
                writer.Write("(");
            }

            Expression.Write(writer);

            if (Expression.ReturnType.IsLazy)
            {
                writer.Write(").Force()");
            }

            writer.Unident();
            writer.WriteLine();

        }
    }
}
