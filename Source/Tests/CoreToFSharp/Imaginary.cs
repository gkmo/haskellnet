using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Haskell.CoreParser.AbstractSyntaxTree;
using Haskell.CoreParser;
using Haskell.CoreToFSharp;

namespace CoreToFSharpTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Imaginary : AbstractTest
    {
        private const string _target = "exe";

        public Imaginary()
        {            
        }
        
        private const string _queensCore = @"imaginary\queens\Main.hcr";
        private const string _queensFSharp = @"imaginary\queens\Main.fs";
        private const string _queensExe = @"Queens.exe";
        private const string _queensOutput = "73712";

        [TestMethod]        
        public void CoreQueensToIL()
        {
            Compile(_queensCore, _queensFSharp, _queensExe, _target, _queensOutput);
        }

        private const string _rfibCore = @"imaginary\rfib\Main.hcr";
        private const string _rfibFSharp = @"imaginary\rfib\Main.fs";
        private const string _rfibExe = @"Rfib.exe";
        private const string _rFibOutput = "866988873";

        [TestMethod]
        public void CoreRfibToIL()
        {
            Compile(_rfibCore, _rfibFSharp, _rfibExe, _target, _rFibOutput);
        }

        private const string _primesCore = @"imaginary\primes\Main.hcr";
        private const string _primesFSharp = @"imaginary\primes\Main.fs";
        private const string _primesExe = @"Primes.exe";
        private const string _primesOutput = "43063";

        [TestMethod]
        public void CorePrimesToIL()
        {
            Compile(_primesCore, _primesFSharp, _primesExe, _target, _primesOutput);
        }

        private const string _takCore = @"imaginary\tak\Main.hcr";
        private const string _takFSharp = @"imaginary\tak\Main.fs";
        private const string _takExe = @"Tak.exe";
        private const string _takOutput = "\"2\\n\"";

        [TestMethod]
        public void CoreTakToIL()
        {
            Compile(_takCore, _takFSharp, _takExe, _target, _takOutput);
        }

        private const string _exp3_8Core = @"imaginary\exp3_8\Main.hcr";
        private const string _exp3_8FSharp = @"imaginary\exp3_8\Main.fs";
        private const string _exp3_8Exe = @"Exp3_8.exe";
        private const string _exp3_8Output = "19683";

        [TestMethod]
        public void CoreExp3_8ToIL()
        {
            Compile(_exp3_8Core, _exp3_8FSharp, _exp3_8Exe, _target, _exp3_8Output);
        }


        private const string _wheel_sieve1Core = @"imaginary\wheel-sieve1\Main.hcr";
        private const string _wheel_sieve1FSharp = @"imaginary\wheel-sieve1\Main.fs";
        private const string _wheel_sieve1Exe = @"Wheel_sieve1.exe";
        private const string _wheel_sieve1Output = "4256249";

        [TestMethod]
        public void CoreWheel_Sieve1ToIL()
        {
            Compile(_wheel_sieve1Core, _wheel_sieve1FSharp, _wheel_sieve1Exe, _target, _wheel_sieve1Output);
        }

        private const string _wheel_sieve2Core = @"imaginary\wheel-sieve2\Main.hcr";
        private const string _wheel_sieve2FSharp = @"imaginary\wheel-sieve2\Main.fs";
        private const string _wheel_sieve2Exe = @"Wheel_sieve2.exe";
        private const string _wheel_sieve2Output = "1020389";

        [TestMethod]
        public void CoreWheel_Sieve2ToIL()
        {
            Compile(_wheel_sieve2Core, _wheel_sieve2FSharp, _wheel_sieve2Exe, _target, _wheel_sieve2Output);
        }

        #region Helpers


        #endregion
    }
}
