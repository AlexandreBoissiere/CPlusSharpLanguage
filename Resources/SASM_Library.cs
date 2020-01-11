using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SASM_Library
{
    public sealed class RAMDataTypeException : Exception
    {
        public RAMDataTypeException() : base("The specified index has an unknown or corrupted type, please check your code.") { }
        public RAMDataTypeException(string message) : base(message) { }
    }
    public sealed class SASM
    {
        private static string GetCode(string path)
        {
            return File.ReadAllText(path);
        }
        private static class REG
        {
            public static long? na = null, nb = null, nc = null, nd = null;
            public static double? fa = null, fb = null, fc = null, fd = null;
            public static string sa = null, sb = null, sc = null, sd = null;
            public static string _ipt { get; internal set; }
            public static string _out { private get { return ""; } set { Console.WriteLine(value); } }
            public static bool? ba = null, bb = null, bc = null, bd = null;

            public static string private_sa = null;
        }

        private static object[] RAM = new object[1024]; // ram

        private static object[] SYSRAM = new object[512]; // sysram
        
        public static void iadd(string regA, string regB, string outReg)
        {
            long? a = null;
            long? b = null;
            // ============================================== //
            if (regA == "na")
            {
                a = REG.na;
            }
            else if (regA == "nb")
            {
                a = REG.nb;
            }
            else if (regA == "nc")
            {
                a = REG.nc;
            }
            else if (regA == "nd")
            {
                a = REG.nd;
            }

            // =========== //

            if (regB == "na")
            {
                b = REG.nb;
            }
            else if (regB == "nb")
            {
                b = REG.nb;
            }
            else if (regB == "nc")
            {
                b = REG.nc;
            }
            else if (regB == "nd")
            {
                b = REG.nd;
            }

            if (a is null || b is null)
            {
                throw new ArgumentNullException("Error : A value error has occured : please verify the name of the specified parameters.");
            }

            if (outReg == "na")
            {
                REG.na = a + b;
            }
            else if (outReg == "nb")
            {
                REG.nb = a + b;
            }
            else if (outReg == "nc")
            {
                REG.nc = a + b;
            }
            else if (outReg == "nd")
            {
                REG.nd = a + b;
            }
        }
        public static void isub(string regA, string regB, string outReg)
        {
            long? a = null;
            long? b = null;
            // ============================================== //
            if (regA == "na")
            {
                a = REG.na;
            }
            else if (regA == "nb")
            {
                a = REG.nb;
            }
            else if (regA == "nc")
            {
                a = REG.nc;
            }
            else if (regA == "nd")
            {
                a = REG.nd;
            }

            // =========== //

            if (regB == "na")
            {
                b = REG.nb;
            }
            else if (regB == "nb")
            {
                b = REG.nb;
            }
            else if (regB == "nc")
            {
                b = REG.nc;
            }
            else if (regB == "nd")
            {
                b = REG.nd;
            }

            if (a is null || b is null)
            {
                throw new ArgumentNullException("Error : A value error has occured : please verify the name of the specified parameters.");
            }

            if (outReg == "na")
            {
                REG.na = a - b;
            }
            else if (outReg == "nb")
            {
                REG.nb = a - b;
            }
            else if (outReg == "nc")
            {
                REG.nc = a - b;
            }
            else if (outReg == "nd")
            {
                REG.nd = a - b;
            }
        }
        public static void imul(string regA, string regB, string outReg)
        {
            long? a = null;
            long? b = null;
            // ============================================== //
            if (regA == "na")
            {
                a = REG.na;
            }
            else if (regA == "nb")
            {
                a = REG.nb;
            }
            else if (regA == "nc")
            {
                a = REG.nc;
            }
            else if (regA == "nd")
            {
                a = REG.nd;
            }

            // =========== //

            if (regB == "na")
            {
                b = REG.nb;
            }
            else if (regB == "nb")
            {
                b = REG.nb;
            }
            else if (regB == "nc")
            {
                b = REG.nc;
            }
            else if (regB == "nd")
            {
                b = REG.nd;
            }

            if (a is null || b is null)
            {
                throw new ArgumentNullException("Error : A value error has occured : please verify the name of the specified parameters.");
            }

            if (outReg == "na")
            {
                REG.na = a * b;
            }
            else if (outReg == "nb")
            {
                REG.nb = a * b;
            }
            else if (outReg == "nc")
            {
                REG.nc = a * b;
            }
            else if (outReg == "nd")
            {
                REG.nd = a * b;
            }
        }
        public static void idiv(string regA, string regB, string outReg)
        {
            long? a = null;
            long? b = null;
            // ============================================== //
            if (regA == "na")
            {
                a = REG.na;
            }
            else if (regA == "nb")
            {
                a = REG.nb;
            }
            else if (regA == "nc")
            {
                a = REG.nc;
            }
            else if (regA == "nd")
            {
                a = REG.nd;
            }

            // =========== //

            if (regB == "na")
            {
                b = REG.nb;
            }
            else if (regB == "nb")
            {
                b = REG.nb;
            }
            else if (regB == "nc")
            {
                b = REG.nc;
            }
            else if (regB == "nd")
            {
                b = REG.nd;
            }

            if (a is null || b is null)
            {
                throw new ArgumentNullException("Error : A value error has occured : please verify the name of the specified parameters.");
            }

            if (outReg == "na")
            {
                REG.na = a / b;
            }
            else if (outReg == "nb")
            {
                REG.nb = a / b;
            }
            else if (outReg == "nc")
            {
                REG.nc = a / b;
            }
            else if (outReg == "nd")
            {
                REG.nd = a / b;
            }
        }

        public static void imov(long value, string outReg)
        {
            if (outReg == "na")
            {
                REG.na = value;
            }
            else if (outReg == "nb")
            {
                REG.nb = value;
            }
            else if (outReg == "nc")
            {
                REG.nc = value;
            }
            else if (outReg == "nd")
            {
                REG.nd = value;
            }
            else
            {
                throw new ArgumentException("Unknown registry !");
            }
        }
        public static void imov(string inReg, string outReg)
        {
            if (inReg == "na")
            {
                syspush(0, REG.na);
            }
            else if (inReg == "nb")
            {
                syspush(0, REG.nb);
            }
            else if (inReg == "nc")
            {
                syspush(0, REG.nc);
            }
            else if (inReg == "nd")
            {
                syspush(0, REG.nd);
            }
            else
            {
                throw new ArgumentException("Unknown registry.");
            }

            if (outReg == "na")
            {
                REG.na = (long)sysaccess(0);
            }
            else if (outReg == "nb")
            {
                REG.nb = (long)sysaccess(0);
            }
            else if (outReg == "nc")
            {
                REG.nc = (long)sysaccess(0);
            }
            else if (outReg == "nd")
            {
                REG.nd = (long)sysaccess(0);
            }
            else
            {
                throw new ArgumentException("Unknown registry.");
            }

            resetsys(0);
        }
        public static void smov(long value, string outReg)
        {
            if (outReg == "sa")
            {
                REG.sa = value.ToString();
            }
            else if (outReg == "sb")
            {
                REG.sb = value.ToString();
            }
            else if (outReg == "sc")
            {
                REG.sc = value.ToString();
            }
            else if (outReg == "sd")
            {
                REG.sd = value.ToString();
            }
            else
            {
                throw new ArgumentException("unknown registry !");
            }
        }
        /// <summary>
        /// Move a string value to a reg.
        /// </summary>
        /// <param name="value">String value if isreg is false | inreg value if isreg is true.</param>
        /// <param name="outReg">Name of the out reg.</param>
        /// <param name="isreg">Define value as a normal string (false) or a in reg name (true).</param>
        public static void smov(string value, string outReg, bool isreg = false)
        {
            if (!isreg)
            {
                if (outReg == "sa")
                {
                    REG.sa = value;
                }
                else if (outReg == "sb")
                {
                    REG.sb = value;
                }
                else if (outReg == "sc")
                {
                    REG.sc = value;
                }
                else if (outReg == "sd")
                {
                    REG.sd = value;
                }
                else
                {
                    throw new ArgumentException("unknown registry !");
                }
            }
            else
            {
                string str = "";

                if (value == "na")
                {
                    str = REG.na.ToString();
                }
                else if (value == "nb")
                {
                    str = REG.nb.ToString();
                }
                else if (value == "nc")
                {
                    str = REG.nc.ToString();
                }
                else if (value == "nd")
                {
                    str = REG.nd.ToString();
                }

                else if (value == "_ipt")
                {
                    str = REG._ipt;
                }

                else
                {
                    throw new ArgumentException("unknown registry !");
                }


                if (outReg == "sa")
                {
                    REG.sa = str;
                }
                else if (outReg == "sb")
                {
                    REG.sb = str;
                }
                else if (outReg == "sc")
                {
                    REG.sc = str;
                }
                else if (outReg == "sd")
                {
                    REG.sd = str;
                }
                else
                {
                    throw new ArgumentException("unknown registry !");
                }
            }
        }
        public static void omov(string inReg, string outReg)
        {
            if (inReg == "na")
            {
                REG.private_sa = REG.na.ToString();
            }
            else if (inReg == "nb")
            {
                REG.private_sa = REG.nb.ToString();
            }
            else if (inReg == "nc")
            {
                REG.private_sa = REG.nc.ToString();
            }
            else if (inReg == "nd")
            {
                REG.private_sa = REG.nd.ToString();
            }

            else if (inReg == "sa")
            {
                REG.private_sa = REG.sa;
            }
            else if (inReg == "sb")
            {
                REG.private_sa = REG.sb;
            }
            else if (inReg == "sc")
            {
                REG.private_sa = REG.sc;
            }
            else if (inReg == "sd")
            {
                REG.private_sa = REG.sd;
            }
            else
            {
                throw new ArgumentException("unknown registry !");
            }

            if (outReg == "_out")
            {
                REG._out = REG.private_sa;
            }
            else
            {
                throw new ArgumentException("unknown registry !");
            }
        }
        public static void inmov(string outReg)
        {
            if (outReg == "_ipt")
            {
                REG._ipt = Console.ReadLine();
            }
            else
            {
                throw new ArgumentException("unknown registry !");
            }
        }

        public static void wait()
        {
            Console.ReadKey(true);
        }
        public static void wait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey(true);
        }

        public static void push(int index, object value)
        {
            RAM[index] = value;
        }
        public static void pull(int index, string outReg)
        {
            if (RAM[index] is long)
            {
                if (outReg == "na")
                {
                    REG.na = (long)RAM[index];
                }
                else if (outReg == "nb")
                {
                    REG.nb = (long)RAM[index];
                }
                else if (outReg == "nc")
                {
                    REG.nc = (long)RAM[index];
                }
                else if (outReg == "nd")
                {
                    REG.nd = (long)RAM[index];
                }
                else
                {
                    throw new ArgumentException("Unappropriated or unknown regsitry.");
                }
            }
            else if (RAM[index] is long)
            {
                if (outReg == "fa")
                {
                    REG.fa = (double)RAM[index];
                }
                else if (outReg == "fb")
                {
                    REG.fb = (double)RAM[index];
                }
                else if (outReg == "fc")
                {
                    REG.fc = (double)RAM[index];
                }
                else if (outReg == "fd")
                {
                    REG.fd = (double)RAM[index];
                }
                else
                {
                    throw new ArgumentException("Unappropriated or unknown regsitry.");
                }
            }
            else if (RAM[index] is string)
            {
                if (outReg == "sa")
                {
                    REG.sa = (string)RAM[index];
                }
                else if (outReg == "sb")
                {
                    REG.sb = (string)RAM[index];
                }
                else if (outReg == "sc")
                {
                    REG.sc = (string)RAM[index];
                }
                else if (outReg == "sd")
                {
                    REG.sd = (string)RAM[index];
                }
                else
                {
                    throw new ArgumentException("Unappropriated or unknown regsitry.");
                }
            }
            else
            {
                throw new RAMDataTypeException();
            }
        }
        private static void syspush(int index, object value)
        {
            SYSRAM[index] = value;
        }
        private static object sysaccess(int index)
        {
            return SYSRAM[index];
        }

        public static void reset(string reg)
        {
            if (reg == "na")
            {
                REG.na = null;
            }
            else if (reg == "nb")
            {
                REG.nb = null;
            }
            else if (reg == "nc")
            {
                REG.nc = null;
            }
            else if (reg == "nd")
            {
                REG.nd = null;
            }

            else if (reg == "fa")
            {
                REG.fa = null;
            }
            else if (reg == "fb")
            {
                REG.fb = null;
            }
            else if (reg == "fc")
            {
                REG.fc = null;
            }
            else if (reg == "fd")
            {
                REG.fd = null;
            }

            else if (reg == "sa")
            {
                REG.sa = null;
            }
            else if (reg == "sb")
            {
                REG.sb = null;
            }
            else if (reg == "sc")
            {
                REG.sc = null;
            }
            else if (reg == "sd")
            {
                REG.sd = null;
            }

            else if (reg == "_ipt")
            {
                REG._ipt = null;
            }

            else if (reg == "ba")
            {
                REG.ba = null;
            }
            else if (reg == "bb")
            {
                REG.bb = null;
            }
            else if (reg == "bc")
            {
                REG.bc = null;
            }
            else if (reg == "bd")
            {
                REG.bd = null;
            }

            else
            {
                throw new ArgumentException("Unknown registry.");
            }
        }
        public static void reset(int index)
        {
            RAM[index] = new object();
        }
        private static void resetsys(int index)
        {
            SYSRAM[index] = new object();
        }

        public static void term()
        {
            Environment.Exit(0);
        }
        public static void term(int code)
        {
            Environment.Exit(code);
        }

        public static void sconvi(string inReg, string outReg)
        {
            long @out;

            if (inReg == "sa")
            {
                @out = long.Parse(REG.sa);
            }
            else if (inReg == "sb")
            {
                @out = long.Parse(REG.sb);
            }
            else if (inReg == "sc")
            {
                @out = long.Parse(REG.sc);
            }
            else if (inReg == "sd")
            {
                @out = long.Parse(REG.sd);
            }
            else
            {
                throw new ArgumentException("Unknown registry.");
            }

            if (outReg == "na")
            {
                REG.na = @out;
            }
            else if (outReg == "nb")
            {
                REG.nb = @out;
            }
            else if (outReg == "nc")
            {
                REG.nc = @out;
            }
            else if (outReg == "nd")
            {
                REG.nd = @out;
            }
            else
            {
                throw new ArgumentException("Unknown registry.");
            }
        }
        public static void iconvs(string inReg, string outReg)
        {    
            if (inReg == "na")
            {
                syspush(0, REG.na);
            }
            else if (inReg == "nb")
            {
                syspush(0, REG.nb);
            }
            else if (inReg == "nc")
            {
                syspush(0, REG.nc);
            }
            else if (inReg == "nd")
            {
                syspush(0, REG.nd);
            }
            else
            {
                throw new ArgumentException("Unknown registry.");
            }

            if (outReg == "sa")
            {
                REG.sa = sysaccess(0).ToString();
            }
            else if (outReg == "sb")
            {
                REG.sb = sysaccess(0).ToString();
            }
            else if (outReg == "sc")
            {
                REG.sc = sysaccess(0).ToString();
            }
            else if (outReg == "sd")
            {
                REG.sd = sysaccess(0).ToString();
            }
            else
            {
                throw new ArgumentException("Unknown registry.");
            }

            resetsys(0);
        }
    }
}