using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreToFSharpTests.Samples
{
    [TestClass]
    public class HaskellWpfTest: AbstractTest
    {
        private const string _target = "module";

        public HaskellWpfTest()
        {            
        }
        
        private const string _wpfCore = @"wpf\Main.hcr";
        private const string _wpfFSharp = @"wpf\Main.fs";
        private const string _wpfBin = @"HaskellWpf.netmodule";

        [TestMethod]        
        public void HaskellWpfToIL()
        {
            Compile(_wpfCore, _wpfFSharp, _wpfBin, _target, null);
        }
    }
}
