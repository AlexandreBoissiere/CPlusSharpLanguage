using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace CompilerLibrary
{
    public class CSharp
    {
        public class Compiler
        {
            public static void compile()
            {
                CodeDomProvider provider = CSharpCodeProvider.CreateProvider("CSharp");

                string InputFileName = @"";
                Console.WriteLine("Path of the file to compile : ");
                InputFileName = Console.ReadLine();

                string input = System.IO.File.ReadAllText(InputFileName);

                string Output = "";
                Console.WriteLine("Output file name : ");
                Output = Console.ReadLine();

                CompilerParameters parameters = new CompilerParameters();

                parameters.GenerateExecutable = true;

                parameters.OutputAssembly = Output;

                CompilerResults results = provider.CompileAssemblyFromSource(parameters, input);

                if (results.Errors.Count > 0)
                {
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        Console.WriteLine("Error on line " + CompErr.Line + "; Error number : " + CompErr.ErrorNumber + "Context : " + CompErr.ErrorText);
                    }
                }
                else
                {
                    Console.WriteLine("Succeful compilation ! ");
                    Console.WriteLine("Type something to exit...");
                    Console.ReadKey(false);
                }
            }
        }
    }
}
