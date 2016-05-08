using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpUnionCaseUnit : FSharpCompilationUnit
    {
        private FSharpConstructorExpressionUnit _reference;
        private FSharpConstructorTypeUnit _expressionType;

        public FSharpUnionCaseUnit(FSharpTypeDeclarationUnit parent)
            : base(parent)
        {
            Parent = parent;
            Types = new List<FSharpTypeUnit>();            
        }

        public string Name { get; set; }

        public new FSharpTypeDeclarationUnit Parent { get; private set; }

        public List<FSharpTypeUnit> Types { get; private set; }

        public bool IsLazy { get; set; }

        public override FSharpTypeUnit ReturnType
        {
            get 
            {
                if (_expressionType == null)
                {
                    _expressionType = new FSharpConstructorTypeUnit();
                    _expressionType.Namespace = Namespace;
                    _expressionType.Module = Module;
                    _expressionType.Name = Name;

                    foreach (var item in Types)
                    {
                        _expressionType.Arguments.Add(item);
                    }
                }

                return _expressionType;    
            }
        }

        public FSharpConstructorExpressionUnit GetReference()
        {
            if (_reference == null)
            {
                _reference = new FSharpConstructorExpressionUnit(this);
                _reference.Name = Name;
                _reference.Assembly = Assembly;
                _reference.Module = Module;
                _reference.Namespace = Namespace;
                _reference.IsLazy = IsLazy;
            }

            return _reference;
        }

        internal override void Write(FSharpWriter writer)
        {
            writer.Write("| {0}", Name);

            if (Types.Count > 0)
            {
                writer.Write(" of (");

                for (var i = 0; i < Types.Count; i++)
                {
                    Types[i].Write(writer);

                    if (i < Types.Count - 1)
                    {
                        writer.Write(" * ");
                    }
                }

                writer.Write(")");
            }

            writer.WriteLine();
        }


    }
}
