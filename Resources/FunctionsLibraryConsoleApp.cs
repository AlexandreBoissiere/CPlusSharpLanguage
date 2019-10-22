using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FunctionsLibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Allocate memory...");
            IntPtr hglobal = Marshal.AllocHGlobal(1000000000);
            IntPtr userMem = Marshal.AllocHGlobal(1024);
            Console.WriteLine("Loading libraries...");
            Console.WriteLine("Preparing Environment...");

            string inputMetaString = "\n@localhost{" + Environment.UserName + "}$~";
            string[] help = new string[5] { "help", "compiler", "memory", "exit", "quit" };

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
                else if (command == "memory")
                {
                    while (command != "quit" || command !=  "exit")
                    {
                        Console.Write(inputMetaString + "MemoryManagement/&~");
                        command = Console.ReadLine();
                        if (command == "free")
                        {
                            Marshal.FreeHGlobal(userMem);
                        }
                        else if (command == "alloc")
                        {
                            Console.WriteLine("How memory do you want to allocate ?");
                            string memAmount = Console.ReadLine();
                            try
                            {
                                int memAmountParsed = int.Parse(memAmount);
                                userMem = Marshal.AllocHGlobal(memAmountParsed);
                            }
                            catch (OverflowException e)
                            {
                                try
                                {
                                    Console.WriteLine(e.Message);
                                    int memAmountParsed = int.MaxValue;
                                    userMem = Marshal.AllocHGlobal(memAmountParsed);
                                }
                                catch (OutOfMemoryException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    ComputerInfo CI = new ComputerInfo();
                                    IntPtr available = (IntPtr)(CI.AvailablePhysicalMemory - (CI.AvailablePhysicalMemory / 1.5));
                                    userMem = Marshal.AllocHGlobal(available);
                                }
                            }
                        }
                        else if (command == "crash")
                        {
                            ComputerInfo CI = new ComputerInfo();
                            try
                            {
                                userMem = Marshal.AllocHGlobal(int.MaxValue);
                            }
                            catch (OutOfMemoryException e)
                            {
                                Console.WriteLine(e.Message);
                                userMem = Marshal.AllocHGlobal(int.MaxValue);
                            }
                        }
                        else if (command == "help")
                        {
                            string[] helpArray = new string[5] { "help", "exit", "quit", "free", "alloc" };
                            foreach (string _Sub in helpArray)
                            {
                                Console.WriteLine("\t" + _Sub);
                            }
                        }
                        else if (command == "quit" || command == "exit") { }
                        else
                            Console.WriteLine("Unknown command !");
                    }
                    continue;
                }
                else if (command == "exit" || command ==  "quit")
                {
                    Console.WriteLine("Releasing memory...");
                    Marshal.FreeHGlobal(hglobal);
                    try
                    {
                        Marshal.FreeHGlobal(userMem);
                    }
                    catch
                    {
                        Console.WriteLine("User memory already releaed !");
                    }
                    Environment.Exit(0);
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
