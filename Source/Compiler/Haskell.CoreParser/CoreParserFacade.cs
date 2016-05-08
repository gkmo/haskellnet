using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Haskell.CoreParser.AbstractSyntaxTree;
using Antlr.Runtime;
using System.IO;

namespace Haskell.CoreParser
{
    public static class CoreParserFacade
    {
        public static Module ParseFromFile(string fileName)
        {
            TextReader tr = new StreamReader(fileName);
            string coreText = tr.ReadToEnd();
            tr.Close();            

            return ParseFromBuffer(coreText);
        }

        public static Module ParseFromBuffer(string buffer)
        {
            buffer = buffer.Replace("SystemziIO", "HaskellSystemziIO");
            buffer = buffer.Replace("GHCziReal.mod", "GHCziReal.hmod");
            buffer = buffer.Replace("GHCziBase.const", "GHCziBase.hconst");
            buffer = buffer.Replace("GHCziInteger.smallInteger", "GHCziHInteger.smallInteger");
            buffer = buffer.Replace("GHCziInteger.timesInteger", "GHCziHInteger.timesInteger");
            buffer = buffer.Replace("GHCziInteger.plusInteger", "GHCziHInteger.plusInteger");
            buffer = buffer.Replace("GHCziInteger.minusInteger", "GHCziHInteger.minusInteger");
            buffer = buffer.Replace("GHCziInteger.quotRemInteger", "GHCziHInteger.quotRemInteger");
            buffer = buffer.Replace("GHCziInteger.ltInteger", "GHCziHInteger.ltInteger");
            buffer = buffer.Replace("GHCziInteger.gtInteger", "GHCziHInteger.gtInteger");
            buffer = buffer.Replace("GHCziInteger.eqInteger", "GHCziHInteger.eqInteger");
            buffer = buffer.Replace("GHCziInteger.neqInteger", "GHCziHInteger.neqInteger");
            buffer = buffer.Replace("GHCziInteger.leInteger", "GHCziHInteger.leInteger");
            buffer = buffer.Replace("GHCziInteger.geInteger", "GHCziHInteger.geInteger");
            buffer = buffer.Replace("DotNetziSystem.zh", "DotNetziHaskellSystem.zh");
            buffer = buffer.Replace("GHCziBase.return", "GHCziBase.hreturn");

            ICharStream input = new ANTLRStringStream(buffer);
            ITokenSource lexer = new CoreLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);

            // Monta a árvore
            CoreParser parser = new CoreParser(tokens);
            parser.TreeAdaptor = new CoreTreeAdaptor();
            return parser.module().Tree as Module;
        }
    }
}
