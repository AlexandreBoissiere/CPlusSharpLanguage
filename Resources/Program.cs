using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Total_library;
using CompilerLibrary;

namespace FunctionsLibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Loading libraries...");
            Console.WriteLine("Preparing Environment...");

            string inputMetaString = "\n@localhost{" + Environment.UserName + "}$~";
            string[] help = new string[2] { "help", "compiler" };

            Console.WriteLine("Environment : OK\nHello " + Environment.UserName + "!\n");

            while (true)
            {
                Console.Write(inputMetaString);
                string command = Console.ReadLine();
                if (command == "compiler")
                {
                    Functions.CompileAssemblyFunction();
                }
                else if (command == "help" || command == "/?")
                {
                    foreach (string _Sub in help)
                    {
                        Console.WriteLine("\t"+_Sub);
                    }
                }
            }
        }
        private static class Functions
        {
            public static void CompileAssemblyFunction()
            {
                Console.WriteLine("Path of the code file : ");
                string pathFile = @"";
                pathFile = Console.ReadLine();

                string codeFileContent = System.IO.File.ReadAllText(pathFile);

                List<char> preParsedText = Total_library.Parser.rawTextParser(codeFileContent);

                List<string> parsedText = Total_library.Parser.parsing_sorter(preParsedText);
                foreach (string _Sub in parsedText)
                {
                    Console.WriteLine(_Sub);
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./compiled.cs", false))
                {
                    file.Write("using System;\nnamespace compiled\n{\nclass Program\n{\nstatic void Main(string[] args)\n{\n");
                    foreach (string _Sub in parsedText)
                    {
                        file.Write(_Sub);
                    }
                    file.Write("\n}\n}\n}");
                }
                Console.WriteLine("Do you to compile the output file ? (O/N) : ");
                string answer = Console.ReadLine();
                if (answer == "O")
                {
                    CompilerLibrary.CSharp.Compiler.compile();
                }
                else { }
            }
        }
    }
}
