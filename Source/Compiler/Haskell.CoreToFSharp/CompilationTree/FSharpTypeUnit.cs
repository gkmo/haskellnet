using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public abstract class FSharpTypeUnit
    {
        private bool _isPrimitive;

        protected FSharpTypeUnit()            
        {
        }

        public virtual string Assembly { get; set; }

        public virtual string Namespace { get; set; }

        public virtual string Module { get; set; }       

        public virtual string Name { get; set; }

        public virtual bool IsPrimitive 
        {
            get { return _isPrimitive || Name.EndsWith("zh"); }
            set { _isPrimitive = value; }
        }

        public virtual bool IsLazy { get; set; }

        internal abstract void Write(FSharpWriter writer);

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
