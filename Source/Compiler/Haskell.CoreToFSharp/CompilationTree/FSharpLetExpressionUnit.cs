using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpLetExpressionUnit : FSharpExpressionUnit
    {
        private FSharpLocalVariableUnit _reference;
        private FSharpTypeUnit _type;

        public FSharpLetExpressionUnit(FSharpCompilationUnit parent, FSharpTypeUnit type)
            : base(parent)
        {
            _type = type;    
        }

        public string Name { get; set; }

        public FSharpExpressionUnit Expression { get; set; }

        public FSharpExpressionUnit Body { get; set; }

        public bool IsRecursive { get; set; }        

        public override FSharpTypeUnit ReturnType
        {
            get { return Body.ReturnType; }
        }

        private FSharpTypeUnit GetExpressionType()
        {
            if (Expression == null)
            {
                return _type;
            }

            return Expression.ReturnType;
        }

        public FSharpLocalVariableUnit GetReference()
        {
            if (_reference == null)
            {
                if (!IsRecursive)
                {
                    _reference = new FSharpLocalVariableUnit(this, Name, Expression.ReturnType);
                }
                else
                {
                    _reference = new FSharpLocalVariableUnit(this, Name, new FSharpTypeReferenceUnit(new GetFSharpType(GetExpressionType)));
                }
            }

            return _reference;
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
                            IsRecursive = Expression == null || Expression.ReturnType is FSharpFunctionTypeUnit;
                            return GetReference();
                        }
                    }
                }
            }

            return base.FindUnit(name, moduleName, namespaceName, assemblyName, bindingTypes);
        }

        internal override void Write(FSharpWriter writer)
        {
            var extraIdentation = false;

            if (!writer.IsStartOfLine)
            {
                writer.WriteLine();
                writer.Ident();
                extraIdentation = true;
            }

            writer.Write("let ");

            if (IsRecursive)
            {
                writer.Write("rec ");
            }

            writer.WriteLine();
            
            writer.Ident();
            writer.Write(Name);
            writer.Write(" : ");
            Expression.ReturnType.Write(writer);
            writer.Write(" = ");     
       
            Expression.Write(writer);

            writer.WriteLine();
            writer.Unident();

            writer.WriteLine("in");
            
            writer.Ident();
            Body.Write(writer);
            writer.Unident();

            if (extraIdentation)
            {
                writer.Unident();
            }
        }


    }
}
