using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Haskell.CoreParser.AbstractSyntaxTree
{
    public class ModuleIdentifier : Node
    {
        private string _assemblyName;
        private string _namespace;
        private string _className;
        
        public ModuleIdentifier(IToken payload)
            : base(payload)
        {            
            
        }

        public string AssemblyName
        {
            get
            {
                if (_assemblyName == null)
                {
                    _assemblyName = ((CommonTree)Children[0]).Text;
                }

                return _assemblyName;
            }
        }

        public string ClassName
        {
            get
            {
                if (_className == null)
                {
                    string[] temp = StgPreProcessor.ProcessString(((CommonTree)Children[1]).Text).Split('.');
                    _className = temp[temp.Length - 1];
                    
                }

                return _className;
            }
        }

        public string Namespace
        {
            get
            {
                if (_namespace == null)
                {
                    string fullName = StgPreProcessor.ProcessString(((CommonTree)Children[1]).Text);
                    string[] temp = fullName.Split('.');
                    _namespace = "";
                    if (temp.Length > 1)
                    {
                        _namespace = fullName.Substring(0, fullName.LastIndexOf('.'));
                    }
                }

                return _namespace;
            }
        }

        public override string Text
        {
            get
            {
                return String.Format("{0}:{1}", AssemblyName, ClassName);
            }
        }

        public override object Accept(ICoreVisitor visitor, object o)
        {
            return o;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1}.{2}", AssemblyName, Namespace, ClassName);
        }
    }
}
