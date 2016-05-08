using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreToFSharpTests
{
    [TestClass]
    public class GhcBase : AbstractTest
    {
        private const string _target = "module";

        public GhcBase()
        {            
        }

        private const string _baseCore = @"base\GHC\Base.hcr";
        private const string _baseFSharp = @"base\GHC\Base.fs";
        private const string _baseBin = @"Base.netmodule";

        [TestMethod]
        public void CoreBaseToIL()
        {
            Compile(_baseCore, _baseFSharp, _baseBin, _target, null);
        }

        private const string _realCore = @"base\GHC\Real.hcr";
        private const string _realFSharp = @"base\GHC\Real.fs";
        private const string _realBin = @"Real.netmodule";

        [TestMethod]        
        public void CoreRealToIL()
        {
            Compile(_realCore, _realFSharp, _realBin, _target, null);
        }

        private const string _classesCore = @"base\GHC\Classes.hcr";
        private const string _classesFSharp = @"base\GHC\Classes.fs";
        private const string _classesBin = @"Classes.netmodule";

        [TestMethod]
        public void CoreClassesToIL()
        {
            Compile(_classesCore, _classesFSharp, _classesBin, _target, null);
        }
    }
}
