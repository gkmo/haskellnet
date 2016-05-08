using System;
using System.Collections.Generic;
using System.Text;

namespace Haskell.CoreParser
{
    static class StgPreProcessor
    {
        private static Dictionary<string, string> _zEncoding;

        static StgPreProcessor()
        {
            _zEncoding = new Dictionary<string, string>();

            _zEncoding.Add("(", "ZL");
            _zEncoding.Add(")", "ZR");
            _zEncoding.Add("[", "ZM");
            _zEncoding.Add("]", "ZN");
            _zEncoding.Add(":", "ZC");
            _zEncoding.Add("Z", "ZZ");
            _zEncoding.Add("z", "zz");
            _zEncoding.Add("&", "za");
            _zEncoding.Add("|", "zb");
            _zEncoding.Add("^", "zc");
            _zEncoding.Add("$", "zd");
            _zEncoding.Add("=", "ze");
            _zEncoding.Add(">", "zg");
            _zEncoding.Add("#", "zh");
            _zEncoding.Add(".", "zi");
            _zEncoding.Add("<", "zl");
            _zEncoding.Add("-", "zm");
            _zEncoding.Add("!", "zn");
            _zEncoding.Add("+", "zp");
            _zEncoding.Add(",", "zq");
            _zEncoding.Add("\\", "zr");
            _zEncoding.Add("/", "zs");
            _zEncoding.Add("*", "zt");
            _zEncoding.Add("_", "zu");
            _zEncoding.Add("%", "zv");
            //_zEncoding.Add("GHCzi", "GHC.");
        }

        public static void ProcessFile(string inputFilename, string outputFilename)
        {
            string buffer = global::System.IO.File.ReadAllText(inputFilename);

            buffer = ProcessString(buffer);

            global::System.IO.File.WriteAllText(outputFilename, buffer);
        }

        public static string ProcessString(string buffer)
        {
            foreach (var key in _zEncoding.Keys)
            {
                buffer = buffer.Replace(_zEncoding[key], key);
            }

            return buffer;
        }
    }
}
