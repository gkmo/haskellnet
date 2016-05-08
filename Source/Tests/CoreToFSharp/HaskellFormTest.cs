using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreToFSharpTests.Samples
{
    [TestClass]
    public class HaskellFormTest: AbstractTest
    {
        private const string _target = "winexe";

        public HaskellFormTest()
        {            
        }
        
        private const string _formCore = @"form\Main.hcr";
        private const string _formFSharp = @"form\Main.fs";
        private const string _formBin = @"HaskellForm.exe";

        [TestMethod]        
        public void HaskellFormToIL()
        {
            Compile(_formCore, _formFSharp, _formBin, _target, null);
        }
    }
}
