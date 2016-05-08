using System.Diagnostics;
using System.IO;
using Haskell.CoreParser;
using Haskell.CoreParser.AbstractSyntaxTree;
using Haskell.CoreToFSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreToFSharpTests
{
    public abstract class AbstractTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        protected virtual void Compile(string coreFile, string fsharpFile, string binFile, string target, string output)
        {
            Module module = CoreParserFacade.ParseFromFile(coreFile);

            Assert.IsNotNull(module);
            
            CoreToFSharp.Convert(module, fsharpFile, target == "winexe");

            ProcessStartInfo fsc = new ProcessStartInfo();
            fsc.Arguments = GetFscArgs(fsharpFile, binFile, target);
            fsc.CreateNoWindow = true;
            fsc.ErrorDialog = true;
            fsc.FileName = "fsc";
            fsc.RedirectStandardError = true;
            fsc.RedirectStandardOutput = true;
            fsc.UseShellExecute = false;

            Process fscProcess = Process.Start(fsc);
            Assert.IsTrue(fscProcess.WaitForExit(60000));

            TestContext.WriteLine(fscProcess.StandardOutput.ReadToEnd());
            TestContext.WriteLine(fscProcess.StandardError.ReadToEnd());

            Assert.AreEqual(0, fscProcess.ExitCode);
            Assert.IsTrue(File.Exists(binFile));

            if (output != null)
            {
                ProcessStartInfo exe = new ProcessStartInfo();
                exe.CreateNoWindow = true;
                exe.ErrorDialog = true;
                exe.FileName = binFile;
                exe.RedirectStandardError = true;
                exe.RedirectStandardOutput = true;
                exe.UseShellExecute = false;

                Process exeProcess = Process.Start(exe);
                Assert.IsTrue(exeProcess.WaitForExit(120000));
                Assert.AreEqual(0, exeProcess.ExitCode);

                Assert.AreEqual(output, exeProcess.StandardOutput.ReadToEnd().TrimEnd());
                Assert.AreEqual("", exeProcess.StandardError.ReadToEnd());
            }
        }

        protected virtual string GetFscArgs(string input, string output, string target)
        {
            return string.Format(
                @"--target:{2} -r base.dll -r ghczmprim.dll -r integerzmgmp.dll -r DotNetProxyzm0zi0zi1.dll --platform:x86 --crossoptimize+ --optimize+ --tailcalls+ --nowarn:40;58 --out:{0} {1}", 
                output, input, target);
        }

    }
}
