using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haskell.CoreToFSharp.CompilationTree
{
    public class FSharpLambdaExpressionUnit : FSharpExpressionUnit
    {
        private FSharpFunctionTypeUnit _type;

        public FSharpLambdaExpressionUnit(FSharpCompilationUnit parent)
            : this(parent, null)
        {
        }

        public FSharpLambdaExpressionUnit(FSharpCompilationUnit parent, FSharpFunctionTypeUnit type)
            : base(parent)
        {
            _type = type;
            Arguments = new List<FSharpArgumentUnit>();
        }

        public FSharpExpressionUnit Expression { get; set; }

        public List<FSharpArgumentUnit> Arguments { get; private set; }        

        public override FSharpTypeUnit ReturnType
        {
            get
            {
                if (_type == null)
                {
                    _type = new FSharpFunctionTypeUnit();

                    var functionType = _type;
                    functionType.BasicType = Arguments[0].ReturnType;

                    for (var i = 1; i < Arguments.Count; i++)
                    {
                        var nextFunctionType = new FSharpFunctionTypeUnit();
                        nextFunctionType.BasicType = Arguments[i].ReturnType;

                        functionType.NextType = nextFunctionType;
                        functionType = nextFunctionType;
                    }

                    functionType.NextType = Expression.ReturnType;
                }

                return _type;
            }           
        }

        public override FSharpCompilationUnit FindUnit(string name, string moduleName, string namespaceName, string assemblyName, List<FSharpTypeUnit> bindingTypes)
        {
            if (string.IsNullOrEmpty(assemblyName) || assemblyName == Assembly)
            {
                if (string.IsNullOrEmpty(namespaceName) || namespaceName == Namespace)
                {
                    if (string.IsNullOrEmpty(moduleName) || moduleName == Module)
                    {
                        foreach (var item in Arguments)
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
            writer.Write("fun ");

            foreach (var item in Arguments)
            {
                item.Write(writer);
                writer.Write(" ");
            }

            writer.WriteLine("->");
            writer.Ident();

            var returnType = ((FSharpFunctionTypeUnit)ReturnType).NextType;
            var functionType = returnType as FSharpFunctionTypeUnit;
            while (functionType != null)
            {
                returnType = functionType.NextType;
                functionType = returnType as FSharpFunctionTypeUnit;
            }

            if (Expression.ReturnType.IsLazy && !returnType.IsLazy)
            {
                writer.Write("(");
            }
            
            Expression.Write(writer);

            if (Expression.ReturnType.IsLazy && !returnType.IsLazy)
            {
                writer.Write(").Force()");
            }

            writer.Unident();
        }
    }
}
