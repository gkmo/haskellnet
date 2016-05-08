using System;
using System.Collections.Generic;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpModuleUnit : FSharpCompilationUnit
    {
        public FSharpModuleUnit()
            : base(null)
        {
            TypeDeclarations = new List<FSharpTypeDeclarationUnit>();
            ValueDeclarations = new List<FSharpValueDeclarationUnit>();
        }

        public override string Assembly { get; set; }

        public override string Namespace { get; set; }

        public override string Module
        {
            get
            {
                return Name;
            }

            set {  }
        }

        public string Name { get; set; }

        public bool HasEntryPoint { get; set; }

        public bool IsWinExe { get; set; }

        public List<FSharpTypeDeclarationUnit> TypeDeclarations { get; private set; }

        public List<FSharpValueDeclarationUnit> ValueDeclarations { get; private set; }

        public override FSharpCompilationUnit FindUnit(string name, string moduleName, string namespaceName, string assemblyName, List<FSharpTypeUnit> bindingTypes)
        {
            if (string.IsNullOrEmpty(assemblyName) || assemblyName == Assembly)
            {
                if (string.IsNullOrEmpty(namespaceName) || namespaceName == Namespace)
                {
                    if (string.IsNullOrEmpty(moduleName) || moduleName == Name)
                    {
                        foreach (var item in ValueDeclarations)
                        {
                            if (item.Name == name)
                            {
                                return item.GetReference();
                            }
                        }

                        foreach (var item in TypeDeclarations)
                        {
                            foreach (var subItem in item.UnionCases)
                            {
                                if (subItem.Name == name)
                                {
                                    return subItem.GetReference();
                                }
                            }
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(assemblyName) && assemblyName != Assembly
                && !string.IsNullOrEmpty(namespaceName) && namespaceName != Namespace
                && !string.IsNullOrEmpty(moduleName) && moduleName != Module)
            {
                return ExternalModulesHelper.FindUnit(name, moduleName, namespaceName, assemblyName, bindingTypes);
            }

            return null;
        }

        public override string ToString()
        {
            var writer = new FSharpWriter();
            writer.CurrentModule = this;
            Write(writer);
            return writer.ToString();
        }

        internal override void Write(FSharpWriter writer)
        {
            writer.CurrentModule = this;

            if (!string.IsNullOrEmpty(Namespace))
            {
                writer.WriteLine("namespace {0}", Namespace);
                writer.WriteLine();
            }
            else if (HasEntryPoint)
            {
                writer.WriteLine("namespace Program", Namespace);
                writer.WriteLine();
            }

            writer.WriteLine("module {0} = ", Name);

            writer.Ident();

            foreach (var item in TypeDeclarations)
            {
                item.Write(writer);
                writer.WriteLine();
            }

            foreach (var item in ValueDeclarations)
            {
                item.Write(writer);                
                writer.WriteLine();
            }

            if (HasEntryPoint)
            {
                if (IsWinExe)
                {
                    writer.WriteLine("[<System.STAThread>]");
                }

                writer.WriteLine("zcmain (GHC.Prim.State (())) |> ignore");
            }

            writer.Unident();

            writer.CurrentModule = null;
        }

        public override FSharpTypeUnit ReturnType
        {
            get { throw new NotImplementedException(); }
        }
    }
}
