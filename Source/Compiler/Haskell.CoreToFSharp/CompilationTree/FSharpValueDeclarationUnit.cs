using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpValueDeclarationUnit : FSharpCompilationUnit
    {
        private FSharpLocalVariableUnit _reference;

        public FSharpValueDeclarationUnit(FSharpCompilationUnit parent)
            : base(parent)
        {
            TypeBindings = new List<FSharpTypeBindingUnit>();
            DependenciesNotFound = new List<string>();
        }

        public string Name { get; set; }

        public FSharpTypeUnit ValueType { get; set; }

        public override FSharpTypeUnit ReturnType
        {
            get { return ValueType; }
        }

        public List<FSharpTypeBindingUnit> TypeBindings { get; private set; }

        public FSharpExpressionUnit Expression { get; set; }

        public bool IsPrivate { get; set; }

        public bool IsRecursive { get; set; }

        public bool IsInline { get; set; }

        public bool IsRecursiveObject { get; set; }        

        public List<string> DependenciesNotFound { get; private set; }

        public FSharpLocalVariableUnit GetReference()
        {
            if (_reference == null)
            {
                _reference = new FSharpLocalVariableUnit(this, Name, new FSharpTypeReferenceUnit(new GetFSharpType(GetFSharpType)));
            }

            return _reference;
        }

        private FSharpTypeUnit GetFSharpType()
        {
            return ValueType;
        }

        public override FSharpCompilationUnit FindUnit(string name, string moduleName, string namespaceName, string assemblyName, List<FSharpTypeUnit> bindingTypes)
        {
            if (string.IsNullOrEmpty(assemblyName) || assemblyName == Assembly)
            {
                if (string.IsNullOrEmpty(namespaceName) || namespaceName == Namespace)
                {
                    if (string.IsNullOrEmpty(moduleName) || moduleName == Module)
                    {
                        if (Name == name)
                        {
                            IsRecursive = true;
                            return GetReference();
                        }
                    }
                }
            }

            var result = base.FindUnit(name, moduleName, namespaceName, assemblyName, bindingTypes);

            if (result == null 
                && (string.IsNullOrEmpty(assemblyName) || assemblyName == Assembly)
                && (string.IsNullOrEmpty(namespaceName) || namespaceName == Namespace)
                && (string.IsNullOrEmpty(moduleName) || moduleName == Module))
            {
                DependenciesNotFound.Add(name);
            }

            return result;
        }

        internal override void Write(FSharpWriter writer)
        {
            var inline = IsInline ? " inline" : string.Empty;

            if (!IsRecursiveObject)
            {
                writer.Write("let ");

                if (IsRecursive)
                {
                    writer.Write("rec ");
                }                
            }
            else
            {                
                writer.Write("and ");
            }

            if (IsPrivate)
            {
                writer.Write("private ");
            }

            writer.Write(Name);

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

            writer.Write(" : ");

            ValueType.Write(writer);

            writer.WriteLine(" = ");
            
            writer.Ident();

            if (ReturnType.IsLazy && !Expression.ReturnType.IsLazy)
            {
                writer.WriteLine("lazy");
                writer.WriteLine("(");
                writer.Ident();
            }

            Expression.Write(writer);

            if (ReturnType.IsLazy && !Expression.ReturnType.IsLazy)
            {
                if (!writer.IsStartOfLine)
                {
                    writer.WriteLine();
                }

                writer.Unident();
                writer.Write(")");
            }

            writer.Unident();

            writer.WriteLine();         
        }
    }
}
