using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreToFSharpTests
{
    [TestClass]
    public class GhcPrim : AbstractTest
    {
        private const string _target = "module";

        public GhcPrim()
        {            
        }
        
        private const string _genericsCore = @"ghc-prim\Generics.hcr";
        private const string _genericsFSharp = @"ghc-prim\Generics.fs";
        private const string _genericsBin = @"Generics.netmodule";

        [TestMethod]        
        public void CoreGenericsToIL()
        {
            Compile(_genericsCore, _genericsFSharp, _genericsBin, _target, null);
        }

        private const string _orderingCore = @"ghc-prim\Ordering.hcr";
        private const string _orderingFSharp = @"ghc-prim\Ordering.fs";
        private const string _orderingBin = @"Ordering.netmodule";

        [TestMethod]
        public void CoreOrdereingToIL()
        {
            Compile(_orderingCore, _orderingFSharp, _orderingBin, _target, null);
        }
    }
}
