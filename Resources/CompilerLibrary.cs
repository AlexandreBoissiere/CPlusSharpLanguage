using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.IO;
using Total_library;

namespace CompilerLibrary
{
    public class CSharp
    {
        public class Compiler
        {
            public static void precompile(TemporaryFiles tempIn, TemporaryFiles tempOut)
            {
                List<char> preparsedText = Parser.rawTextParser(File.ReadAllText(tempIn.path));
                List<string> parsedText = Parser.parsing_sorter(preparsedText);
                using (StreamWriter temp_out = new StreamWriter(tempOut.path, false))
                {
                    temp_out.Write("using System;\nnamespace compiled\n{\nclass Program\n{\nstatic void Main(string[] args)\n{\n");
                    foreach (string sub in parsedText)
                    {
                        temp_out.Write(sub);
                    }
                    temp_out.Write("\n}\n}\n}");
                }
            }
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
            public static List<string> compile(string InputFileName, string OutputFileName)
            {
                List<string> Errors = new List<string>();
                CodeDomProvider provider = CSharpCodeProvider.CreateProvider("CSharp");

                string input = System.IO.File.ReadAllText(InputFileName);

                CompilerParameters parameters = new CompilerParameters();

                parameters.GenerateExecutable = true;

                parameters.OutputAssembly = OutputFileName;

                CompilerResults results = provider.CompileAssemblyFromSource(parameters, input);

                if (results.Errors.Count > 0)
                {
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        Errors.Add("Error on line " + CompErr.Line + "; Error number : " + CompErr.ErrorNumber + "Context : " + CompErr.ErrorText);
                    }
                }
                return Errors;
            }
        }
    }
    public sealed class TemporaryFiles
    {
        public static List<TemporaryFiles> instances = new List<TemporaryFiles>();
        public string path { get; set; }
        public bool closed { get; set; }
        /// <summary>
        /// Constructeur de TemporaryFiles, classe de gestion de fichier temporaires.
        /// </summary>
        /// <param name="pathOfNewFile">Chemin d'accès vers le nouveau fichier.</param>
        public TemporaryFiles(string pathOfNewFile)
        {
            path = pathOfNewFile;
            if (!File.Exists(path))
            {
                var create = File.Create(path);
                create.Close();
            }
            instances.Add(this);
        }
        /// <summary>
        /// Supprime un fichier mais ne supprime pas l'instance.
        /// </summary>
        public void Close()
        {
            File.Delete(path);
            this.closed = true;
        }
        /// <summary>
        /// Restaure le fichier mais sans son contenu, sert à éviter de recréer une instance.
        /// </summary>
        public void Renew()
        {
            if (!closed)
            {
                var create = File.Create(path);
            }
        }
        /// <summary>
        /// Supprime un fichier depuis un appel statique, version statique de this.Close().
        /// </summary>
        /// <param name="path"></param>
        public static void Close(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        ~TemporaryFiles() { foreach (TemporaryFiles subTemp in instances) { if (!subTemp.closed) { subTemp.Close(); } } }
    }
}
