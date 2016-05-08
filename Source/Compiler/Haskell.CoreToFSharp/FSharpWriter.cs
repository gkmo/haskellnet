using System.Collections.Generic;
using System.Text;

using Haskell.CoreToFSharp.CompilationTree;

namespace Haskell.CoreToFSharp
{
    internal class FSharpWriter
    {
        private const string Identation = "    ";

        private readonly Stack<StringBuilder> _frames;
        private StringBuilder _writer;        

        public FSharpWriter()
            : this(new StringBuilder())
        {            
        }

        public FSharpWriter(StringBuilder writer)            
        {
            _writer = writer;
            _frames = new Stack<StringBuilder>();
            _frames.Push(writer);
        }

        public FSharpModuleUnit CurrentModule { get; set; }

        public bool IsStartOfLine
        {
            get
            {
                return _writer.Length == 0 || _writer.ToString().EndsWith("\n");
            }
        }

        public void Ident()
        {
            var frame = new StringBuilder();
            _frames.Push(frame);
            _writer = frame;
        }

        public void Unident()
        {            
            _frames.Pop();
            
            var block = _writer.ToString();
            
            _writer = _frames.Peek();

            WriteBlock(block);
        }

        public void WriteLine(string format, params object[] args)
        {            
            _writer.AppendLine(string.Format(format, args));
        }       

        public void Write(string format, params object[] args)
        {
            _writer.AppendFormat(format, args);
        }

        public void WriteLine()
        {
            _writer.AppendLine();            
        }

        public override string ToString()
        {
            return _writer.ToString();
        }

        private void WriteBlock(string text)
        {
            var start = 0;
            int end;

            do
            {
                end = text.IndexOf('\n', start);

                if (end != -1)
                {
                    _writer.AppendFormat("{0}{1}\n", Identation, text.Substring(start, end - start));
                }
                else if (start < text.Length)
                {
                    _writer.AppendFormat("{0}{1}", Identation, text.Substring(start));
                }

                start = end + 1;
            }
            while (end != -1);
        }
    }
}
