using System;
using System.Diagnostics;
using System.Text;

namespace Haskell.Compiler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("hnc.exe [option 1] [option 2] [filename.hs]");
            }
            else
            {
                var sourceFile = args[args.Length - 1];

                if (sourceFile.EndsWith("hs"))
                {
                    var ghc = new ProcessStartInfo
                                  {
                                      Arguments = GenerateGhcArgs(args) + " " + sourceFile,
                                      CreateNoWindow = true,
                                      ErrorDialog = true,
                                      FileName = "ghc",
                                      RedirectStandardError = true,
                                      RedirectStandardOutput = true,
                                      UseShellExecute = false
                                  };

                    Console.WriteLine("Starting GHC compilation ({0})...", ghc.Arguments);

                    var ghcProcess = Process.Start(ghc);

                    if (ghcProcess == null)
                    {
                        Console.WriteLine("Could not find GHC compiler. Make sure ghc.exe is in your PATH");
                        return;
                    }

                    ghcProcess.WaitForExit();

                    Console.Write(ghcProcess.StandardOutput.ReadToEnd());
                    Console.Write(ghcProcess.StandardError.ReadToEnd());

                    Console.WriteLine("GHC compilation ended with {0}", ghcProcess.ExitCode);

                    if (ghcProcess.ExitCode != 0)
                    {
                        return;
                    }
                }                

                var coreFile = sourceFile.Replace(".hs", ".hcr");

                Console.WriteLine("Parsing core file {0}...", coreFile);

                var module = CoreParser.CoreParserFacade.ParseFromFile(coreFile);

                var fsharpFile = sourceFile.Replace(".hs", ".fs");

                Console.WriteLine("Translating to F#...");

                CoreToFSharp.CoreToFSharp.Convert(module, fsharpFile, IsWinExe(args));

                var fsc = new ProcessStartInfo
                                           {
                                               Arguments = GenerateFscArgs(args) + " " + fsharpFile, 
                                               CreateNoWindow = true, 
                                               ErrorDialog = true, 
                                               FileName = "fsc", 
                                               RedirectStandardError = true, 
                                               RedirectStandardOutput = true, 
                                               UseShellExecute = false
                                           };

                Console.WriteLine("Compiling the F# file ({0})...", fsc.Arguments);

                var fscProcess = Process.Start(fsc);
                if (fscProcess == null)
                {
                    Console.WriteLine("Could not find F# compiler. Make sure fsc.exe is in your PATH");
                    return;
                }

                fscProcess.WaitForExit();

                Console.Write(fscProcess.StandardOutput.ReadToEnd());
                Console.Write(fscProcess.StandardError.ReadToEnd());

                Console.WriteLine("Compilation finished!");
            }           
        }

        private static bool IsWinExe(string[] args)
        {
            foreach (var item in args)
            {
                if (item.Contains("winexe"))
                {
                    return true;
                }
            }

            return false;
        }

        private static string GenerateFscArgs(string[] args)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < args.Length - 1; i++)
            {
                if (!args[i].StartsWith("-ghc"))
                {
                    sb.Append(" ");
                    sb.Append(args[i]);
                }
            }

            return sb.ToString();
        }

        private static string GenerateGhcArgs(string[] args)
        {
            var sb = new StringBuilder("-fext-core -C");

            for (var i = 0; i < args.Length - 1; i++)
            {
                if (args[i].StartsWith("-ghc"))
                {
                    sb.Append(" ");
                    sb.Append(args[i].Substring(4));
                }
            }

            return sb.ToString();
        }
    }
}
