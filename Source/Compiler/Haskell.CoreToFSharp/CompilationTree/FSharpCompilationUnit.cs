using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public abstract class FSharpCompilationUnit
    {
        protected FSharpCompilationUnit(FSharpCompilationUnit parent)
        {
            Parent = parent;
        }

        public FSharpCompilationUnit Parent { get; protected set; }

        public virtual string Assembly
        {
            get { return Parent.Assembly; }
            set { }
        }

        public virtual string Namespace
        {
            get { return Parent.Namespace; }
            set { }
        }

        public virtual string Module
        {
            get { return Parent.Module; }
            set { }
        }

        public abstract FSharpTypeUnit ReturnType { get; }

        internal virtual void Write(FSharpWriter writer)
        {

        }

        public virtual FSharpCompilationUnit FindUnit(string name, string moduleName, string namespaceName, string assemblyName, List<FSharpTypeUnit> bindingTypes)
        {
            return Parent.FindUnit(name, moduleName, namespaceName, assemblyName, bindingTypes);
        }

        public override string ToString()
        {
            var fakeModule = new FSharpModuleUnit();
            fakeModule.Assembly = "Fake";
            fakeModule.Namespace = "Fake";
            fakeModule.Name = "Fake";

            var writer = new FSharpWriter();
            writer.CurrentModule = fakeModule;
            Write(writer);
            return writer.ToString();
        }
    }
}
