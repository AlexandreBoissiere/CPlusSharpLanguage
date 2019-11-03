using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Total_library;

namespace Encoder_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Do you want to encode [1] | to decode [2] | to quit [0] : ");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Do you want to encode a file (1) or a string (2) : ");
                    if (Console.ReadLine() == "1")
                    {
                        Console.WriteLine("Path of the input file : ");
                        var inputFile = Console.ReadLine();
                        var toEncode = File.ReadAllText(inputFile);
                        var encoder = new GetHash.FromChar();
                        var encoded = encoder.GetHash(toEncode);
                        Console.WriteLine("encoded string : ");
                        Console.WriteLine(encoded);
                        Console.WriteLine("Do you want to write the encoded string in a file ? (O/N) : ");
                        if (Console.ReadLine() == "O")
                        {
                            File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\output.txt", encoded);
                            Console.WriteLine("Search the output file on your desktop (output.txt).");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            continue;
                        }
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        Console.WriteLine("String to encode : \n");
                        var toEncode = Console.ReadLine();
                        var encoder = new GetHash.FromChar();
                        var encoded = encoder.GetHash(toEncode);
                        Console.WriteLine("encoded string : ");
                        Console.WriteLine(encoded);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        continue;
                    }
                    else
                        Console.WriteLine("Unknown command !");continue;
                }
                else if (Console.ReadLine() == "2")
                {
                    Console.WriteLine("Do you want to decode a file (1) or a string (2) : ");
                    if (Console.ReadLine() == "1")
                    {
                        Console.WriteLine("Path of the input file : ");
                        var inputFile = Console.ReadLine();
                        var toDecode = File.ReadAllText(inputFile);
                        var decoder = new GetHash.FromChar();
                        var decoded = decoder.InverseHash(toDecode);
                        Console.WriteLine("decoded string : ");
                        Console.WriteLine(decoded);
                        Console.WriteLine("Do you want to write the decoded string in a file ? (O/N) : ");
                        if (Console.ReadLine() == "O")
                        {
                            File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Dektop\output.txt", decoded);
                            Console.WriteLine("Search the output file on your desktop (output.txt).");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            continue;
                        }
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        Console.WriteLine("String to decode : \n");
                        var toDecode = Console.ReadLine();
                        var decoder = new GetHash.FromChar();
                        var decoded = decoder.InverseHash(toDecode);
                        Console.WriteLine("decoded string : ");
                        Console.WriteLine(decoded);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        continue;
                    }
                    else
                        Console.WriteLine("Unknown command");
                }
                else
                {
                    Console.WriteLine("Are you sure to exit the application ? (O/N) : ");
                    ConsoleKeyInfo input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.O)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
