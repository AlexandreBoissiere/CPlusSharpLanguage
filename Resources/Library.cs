using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Total_library
{
    public sealed class Errors
    {
        public static class Maths
        {
            public static Exception ZeroDivisionError = new Exception("Can't divise with 0 !");
        }
        public static class DisplayFunctions
        {
            public static Exception PrintLError = new Exception("Can't display this string ! Please check your code.");
            public static Exception PrintAError = new Exception("Can't display ans append this string ! Please check your code.");
            public static Exception PrintFError = new Exception("Can't display this array ! Please check your code.");
            public static Exception PrintFAError = new Exception("Can't display and append this array ! Please check your code.");
        }
        public static class Parser
        {
            public static Exception ParsingError = new Exception("Can't parse the given text ! Please check it.");
        }
        public static class Types
        {
            public static Exception NullableError = new Exception("Your nullable variable is not null, please check your code or find an alternative.");
            public static Exception UIntError = new Exception("Value of your variable is not an unsigned int !");
            public static Exception UFloatError = new Exception("Value of your variable is not an unsigned float !");
            public static Exception UShortError = new Exception("Value of your variable is not an unsigned short !");
            public static Exception ULongError = new Exception("Value of your variable is not an unsigned long !");
            public static Exception UDoubleError = new Exception("Value of your variable is not an unsigned double !");
        }
        public static class Log
        {
            public static Exception WriteLineValueException = new Exception("The value of the WriteLine arg must be true or false !");
        }
        public static class FilesIO
        {
            public static Exception FileNotFound = new Exception("Referenced file hasn't been found !");
        }
    }
    public sealed class Maths
    {
        public static double Add(double[] Nums)
        {
            double result = 0;
            foreach(double Num in Nums)
            {
                result += Num;
            }
            return result;
        }
        public static double Less(double[] Nums)
        {
            double result = 0;
            foreach(double Num in Nums)
            {
                result -= Num;
            }
            return result;
        }
        public static double Mul(double[] Nums)
        {
            double result = 1;
            foreach(double Num in Nums)
            {
                result *= Num;
            }
            return result;
        }
        public static double Div(double ToDiv,double[] Nums)
        {
            double result = ToDiv;
            foreach(double Num in Nums)
            {
                if(Num == 0) { throw Errors.Maths.ZeroDivisionError; }
                else
                {
                    result /= Num;
                }
            }
            return result;
        }
        public static int PGCD(int a, int b)
        {
            int r,x;
            if (a < b)
            {
                x = a;
                a = b;
                b = x;
            }
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        public static int PPCM(int a, int b)
        {
            int PGCD = Maths.PGCD(a, b);

            int PPCM = (a * b) / PGCD;

            return PPCM;
        }
        public static int Exponent(int a)
        {
            int j = 1;
            for (int i = 1; i < a + 1; i++)
            {
                j *= i;
            }
            return j;
        }
        public static double PythagoreTheorem(double a, double b)
        {
            double result;
            result = Math.Pow(a, 2) + Math.Pow(b, 2);
            result = Math.Sqrt(result);
            return result;
        }
        public static decimal SQRT(decimal squareT)
        {
            decimal sqrt = 0;
            decimal increment = 1;
            while (true)
            {
                if ((increment * increment) == squareT)
                {
                    break;
                }
                else
                {
                    increment++;
                    continue;
                }
            }
            sqrt = increment;
            return sqrt;
        }
        public static double ToSquare(double toSquare)
        {
            return (toSquare * toSquare);
        }
    }
    public sealed class DisplayFunctions
    {
        public static void PrintL(string str)
        {
            try
            {
                Console.WriteLine(str);
            }
            catch { throw Errors.DisplayFunctions.PrintLError; }
        }
        public static void PrintA(string str)
        {
            try
            {
                Console.Write(str);
            }
            catch { throw Errors.DisplayFunctions.PrintAError; }
        }
        public static void PrintF(string[] Array)
        {
            try
            {
                foreach(string _Element in Array)
                {
                    Console.WriteLine(_Element);
                }
            }
            catch { throw Errors.DisplayFunctions.PrintFError; }
        }
        public static void PrintFA(string[] Array)
        {
            try
            {
                foreach(string _Element in Array)
                {
                    Console.Write(_Element);
                }
            }
            catch { throw Errors.DisplayFunctions.PrintFAError; }
        }
    }
    public sealed class InputsFunctions
    {
        public static string ReadL()
        {
            string input;
            input = Console.ReadLine();
            return input;
        }
        public static ConsoleKeyInfo ReadK(bool display = true)
        {
            ConsoleKeyInfo input = Console.ReadKey(display);
            return input;
        }
        public static void ReadVoid(bool display = true)
        {
            Console.ReadKey(display);
        }
    }
    public sealed class Parser
    {
        public static List<char> rawTextParser(string txt)
        {
            List<char> parsed = new List<char>();

            try
            {
                foreach (char _Sub in txt)
                {
                    parsed.Add(_Sub);
                }
            }
            catch { throw Errors.Parser.ParsingError; }

            return parsed;
        }
        public static List<string> parsing_sorter(List<char> Parsed)
        {
            List<string> sorted_parsing = new List<string>();

            for (int i = 0; i < Parsed.Count; ++i)
            {
                // IFs statements sorting
                if (Parsed[i] == 'e' && Parsed[i + 1] == 'l' && Parsed[i + 2] == 's' && Parsed[i + 3] == 'e' && Parsed[i + 4] == 'i' && Parsed[i + 5] == 'f')
                {
                    sorted_parsing.Add("else if");
                    i += 5;
                    continue;
                }
                else if (Parsed[i] == 'e' && Parsed[i + 1] == 'l' && Parsed[i + 2] == 's' && Parsed[i + 3] == 'e' && Parsed[i + 4] == ' ' && Parsed[i + 5] == 'i' && Parsed[i + 6] == 'f')
                {
                    sorted_parsing.Add("else if");
                    i += 6;
                    continue;
                }
                else if (Parsed[i] == 'e' && Parsed[i + 1] == 'l' && Parsed[i + 2] == 's' && Parsed[i + 3] == 'i' && Parsed[i + 4] == 'f')
                {
                    sorted_parsing.Add("else if");
                    i += 4;
                    continue;
                }
                else if (Parsed[i] == 'i' && Parsed[i + 1] == 'f')
                {
                    sorted_parsing.Add("if");
                    i += 1;
                    continue;
                }
                else if (Parsed[i] == 'e' && Parsed[i + 1] == 'l' && Parsed[i + 2] == 's' && Parsed[i + 3] == 'e')
                {
                    sorted_parsing.Add("else");
                    i += 3;
                    continue;
                }

                // Loops statements sorting
                else if (Parsed[i] == 'w' && Parsed[i + 1] == 'h' && Parsed[i + 2] == 'i' && Parsed[i + 3] == 'l' && Parsed[i + 4] == 'e')
                {
                    sorted_parsing.Add("while");
                    i += 4;
                    continue;
                }
                else if (Parsed[i] == 'f' && Parsed[i + 1] == 'o' && Parsed[i + 2] == 'r')
                {
                    sorted_parsing.Add("for");
                    i += 2;
                    continue;
                }
                else if (Parsed[i] == 'f' && Parsed[i + 1] == 'o' && Parsed[i + 2] == 'r' && Parsed[i + 3] == 'e' && Parsed[i + 4] == 'a' && Parsed[i + 5] == 'c' &&
                    Parsed[i + 6] == 'h')
                {
                    sorted_parsing.Add("foreach");
                    i += 6;
                    continue;
                }

                // Types statements sorting
                //// Int
                else if (Parsed[i] == '_' && Parsed[i + 1] == 'I' && Parsed[i + 2] == 'n' && Parsed[i + 3] == 't' && Parsed[i + 4] == 'e' && Parsed[i + 5] == 'g' &&
                    Parsed[i+6] == 'e' && Parsed[i+7] == 'r')
                {
                    sorted_parsing.Add("int");
                    i += 7;
                    continue;
                }
                else if (Parsed[i] == '_' && Parsed[i + 1] == 'I' && Parsed[i+2] == 'n' && Parsed[i+3] == 't')
                {
                    sorted_parsing.Add("int");
                    i += 3;
                    continue;
                }
                else if (Parsed[i] == '_' && Parsed[i+1] == 'I' && Parsed[i+2] == 't' && Parsed[i+3] == 'g')
                {
                    sorted_parsing.Add("int");
                    i += 3;
                    continue;
                }
                else if (Parsed[i] == '_' && Parsed[i+1] == 'I' && Parsed[i+2] == 'n' && Parsed[i+3] == 't' && Parsed[i+4] == 'g')
                {
                    sorted_parsing.Add("int");
                    i += 4;
                    continue;
                }

                //// Boolean
                else if (Parsed[i] == '_' && Parsed[i+1] == 'B' && Parsed[i+2] == 'o' && Parsed[i+3] == 'o' && Parsed[i+4] == 'l' && Parsed[i+5] == 'e' &&
                    Parsed[i+6] == 'a' && Parsed[i+7] == 'n')
                {
                    sorted_parsing.Add("bool");
                    i += 7;
                    continue;
                }

                // Code separators statements sorting
                else if (Parsed[i] == '(')
                {
                    sorted_parsing.Add("(");
                    continue;
                }
                else if (Parsed[i] == ')')
                {
                    sorted_parsing.Add(")");
                    continue;
                }
                else if (Parsed[i] == '[')
                {
                    sorted_parsing.Add("[");
                    continue;
                }
                else if (Parsed[i] == ']')
                {
                    sorted_parsing.Add("]");
                    continue;
                }
                else if (Parsed[i] == '{')
                {
                    sorted_parsing.Add("{");
                    continue;
                }
                else if (Parsed[i] == '}')
                {
                    sorted_parsing.Add("}");
                    continue;
                }

                // Quotation marks statements sorting
                else if (Parsed[i] == '"')
                {
                    sorted_parsing.Add("\"");
                    continue;
                }
                else if (Parsed[i] == '\'')
                {
                    sorted_parsing.Add("'");
                    continue;
                }

                // separators statement sorting
                else if (Parsed[i] == ',')
                {
                    sorted_parsing.Add(",");
                    continue;
                }
                else if (Parsed[i] == ';')
                {
                    sorted_parsing.Add(";");
                    continue;
                }
                else if (Parsed[i] == '.')
                {
                    sorted_parsing.Add(".");
                    continue;
                }

                // Operators statement sorting
                else if (Parsed[i] == '+')
                {
                    sorted_parsing.Add("+");
                    continue;
                }
                else if (Parsed[i] == '-')
                {
                    sorted_parsing.Add("-");
                    continue;
                }
                else if (Parsed[i] == '*')
                {
                    sorted_parsing.Add("*");
                    continue;
                }
                else if (Parsed[i] == '/')
                {
                    sorted_parsing.Add("/");
                    continue;
                }
                else if (Parsed[i] == '=')
                {
                    sorted_parsing.Add("=");
                    continue;
                }

                // String litterals separators statement sorting
                else if (Parsed[i] == '-')
                {
                    sorted_parsing.Add("-");
                    continue;
                }
                else if (Parsed[i] == '_')
                {
                    sorted_parsing.Add("_");
                    continue;
                }
                else if (Parsed[i] == '|')
                {
                    sorted_parsing.Add("|");
                    continue;
                }
                else if (Parsed[i] == ' ')
                {
                    sorted_parsing.Add(" ");
                }
                
                // Symbols statement sorting
                else if (Parsed[i] == '#')
                {
                    sorted_parsing.Add("#");
                    continue;
                }
                else if (Parsed[i] == '~')
                {
                    sorted_parsing.Add("~");
                    continue;
                }
                else if (Parsed[i] == '&')
                {
                    sorted_parsing.Add("&");
                    continue;
                }
                else if (Parsed[i] == '^')
                {
                    sorted_parsing.Add("^");
                    continue;
                }
                else if (Parsed[i] == '¨')
                {
                    sorted_parsing.Add("¨");
                    continue;
                }
                else if (Parsed[i] == '$')
                {
                    sorted_parsing.Add("$");
                    continue;
                }
                else if (Parsed[i] == '£')
                {
                    sorted_parsing.Add("£");
                    continue;
                }
                else if (Parsed[i] == '%')
                {
                    sorted_parsing.Add("%");
                    continue;
                }
                else if (Parsed[i] == '!')
                {
                    sorted_parsing.Add("!");
                    continue;
                }
                else if (Parsed[i] == '§')
                {
                    sorted_parsing.Add("§");
                    continue;
                }
                else if (Parsed[i] == ':')
                {
                    sorted_parsing.Add(":");
                    continue;
                }
                else if (Parsed[i] == '?')
                {
                    sorted_parsing.Add("?");
                    continue;
                }
                else if (Parsed[i] == '¤')
                {
                    sorted_parsing.Add("¤");
                    continue;
                }
                else if (Parsed[i] == 'µ')
                {
                    sorted_parsing.Add("µ");
                    continue;
                }
                else if (Parsed[i] == '<')
                {
                    sorted_parsing.Add("<");
                    continue;
                }
                else if (Parsed[i] == '>')
                {
                    sorted_parsing.Add(">");
                    continue;
                }

                // Numbers statement sorting
                else if (Parsed[i] == '0')
                {
                    sorted_parsing.Add("0");
                    continue;
                }
                else if (Parsed[i] == '1')
                {
                    sorted_parsing.Add("1");
                    continue;
                }
                else if (Parsed[i] == '2')
                {
                    sorted_parsing.Add("2");
                    continue;
                }
                else if (Parsed[i] == '3')
                {
                    sorted_parsing.Add("3");
                    continue;
                }
                else if (Parsed[i] == '4')
                {
                    sorted_parsing.Add("4");
                    continue;
                }
                else if (Parsed[i] == '5')
                {
                    sorted_parsing.Add("5");
                    continue;
                }
                else if (Parsed[i] == '6')
                {
                    sorted_parsing.Add("6");
                    continue;
                }
                else if (Parsed[i] == '7')
                {
                    sorted_parsing.Add("7");
                    continue;
                }
                else if (Parsed[i] == '8')
                {
                    sorted_parsing.Add("8");
                    continue;
                }
                else if (Parsed[i] == '9')
                {
                    sorted_parsing.Add("9");
                    continue;
                }

                // Letters statement
                // Lowercases
                else if (Parsed[i] == 'a')
                {
                    sorted_parsing.Add("a");
                    continue;
                }
                else if (Parsed[i] == 'b')
                {
                    sorted_parsing.Add("b");
                    continue;
                }
                else if (Parsed[i] == 'c')
                {
                    sorted_parsing.Add("c");
                    continue;
                }
                else if (Parsed[i] == 'd')
                {
                    sorted_parsing.Add("d");
                }
                else if (Parsed[i] == 'e')
                {
                    sorted_parsing.Add("e");
                }
                else if (Parsed[i] == 'f')
                {
                    sorted_parsing.Add("f");
                }
                else if (Parsed[i] == 'g')
                {
                    sorted_parsing.Add("g");
                }
                else if (Parsed[i] == 'h')
                {
                    sorted_parsing.Add("h");
                }
                else if (Parsed[i] == 'i')
                {
                    sorted_parsing.Add("i");
                }
                else if (Parsed[i] == 'j')
                {
                    sorted_parsing.Add("j");
                }
                else if (Parsed[i] == 'k')
                {
                    sorted_parsing.Add("k");
                }
                else if (Parsed[i] == 'l')
                {
                    sorted_parsing.Add("l");
                }
                else if (Parsed[i] == 'm')
                {
                    sorted_parsing.Add("m");
                }
                else if (Parsed[i] == 'n')
                {
                    sorted_parsing.Add("n");
                }
                else if (Parsed[i] == 'o')
                {
                    sorted_parsing.Add("o");
                }
                else if (Parsed[i] == 'p')
                {
                    sorted_parsing.Add("p");
                }
                else if (Parsed[i] == 'q')
                {
                    sorted_parsing.Add("q");
                }
                else if (Parsed[i] == 'r')
                {
                    sorted_parsing.Add("r");
                }
                else if (Parsed[i] == 's')
                {
                    sorted_parsing.Add("s");
                }
                else if (Parsed[i] == 't')
                {
                    sorted_parsing.Add("t");
                }
                else if (Parsed[i] == 'u')
                {
                    sorted_parsing.Add("u");
                }
                else if (Parsed[i] == 'v')
                {
                    sorted_parsing.Add("v");
                }
                else if (Parsed[i] == 'w')
                {
                    sorted_parsing.Add("w");
                }
                else if (Parsed[i] == 'x')
                {
                    sorted_parsing.Add("x");
                }
                else if (Parsed[i] == 'y')
                {
                    sorted_parsing.Add("y");
                }
                else if (Parsed[i] == 'z')
                {
                    sorted_parsing.Add("z");
                }

                // Uppercases
                else if (Parsed[i] == 'A')
                {
                    sorted_parsing.Add("A");
                }
                else if (Parsed[i] == 'B')
                {
                    sorted_parsing.Add("B");
                }
                else if (Parsed[i] == 'C')
                {
                    sorted_parsing.Add("C");
                }
                else if (Parsed[i] == 'D')
                {
                    sorted_parsing.Add("D");
                }
                else if (Parsed[i] == 'E')
                {
                    sorted_parsing.Add("E");
                }
                else if (Parsed[i] == 'F')
                {
                    sorted_parsing.Add("F");
                }
                else if (Parsed[i] == 'G')
                {
                    sorted_parsing.Add("G");
                }
                else if (Parsed[i] == 'H')
                {
                    sorted_parsing.Add("H");
                }
                else if (Parsed[i] == 'I')
                {
                    sorted_parsing.Add("I");
                }
                else if (Parsed[i] == 'J')
                {
                    sorted_parsing.Add("J");
                }
                else if (Parsed[i] == 'K')
                {
                    sorted_parsing.Add("K");
                }
                else if (Parsed[i] == 'L')
                {
                    sorted_parsing.Add("L");
                }
                else if (Parsed[i] == 'M')
                {
                    sorted_parsing.Add("M");
                }
                else if (Parsed[i] == 'N')
                {
                    sorted_parsing.Add("N");
                }
                else if (Parsed[i] == 'O')
                {
                    sorted_parsing.Add("O");
                }
                else if (Parsed[i] == 'P')
                {
                    sorted_parsing.Add("P");
                }
                else if (Parsed[i] == 'Q')
                {
                    sorted_parsing.Add("Q");
                }
                else if (Parsed[i] == 'R')
                {
                    sorted_parsing.Add("R");
                }
                else if (Parsed[i] == 'S')
                {
                    sorted_parsing.Add("S");
                }
                else if (Parsed[i] == 'T')
                {
                    sorted_parsing.Add("T");
                }
                else if (Parsed[i] == 'U')
                {
                    sorted_parsing.Add("U");
                }
                else if (Parsed[i] == 'V')
                {
                    sorted_parsing.Add("V");
                }
                else if (Parsed[i] == 'W')
                {
                    sorted_parsing.Add("W");
                }
                else if (Parsed[i] == 'X')
                {
                    sorted_parsing.Add("X");
                }
                else if (Parsed[i] == 'Y')
                {
                    sorted_parsing.Add("Y");
                }
                else if (Parsed[i] == 'Z')
                {
                    sorted_parsing.Add("Z");
                }
            }
            return sorted_parsing;
        }
    }
    public sealed class Types
    {
        public sealed class _Int
        {
            private int Int;
            public _Int(int value) => Int = value;
            public int INT() => Int;

            public static implicit operator int(_Int n) => n.INT();
            public static explicit operator _Int(int x) => new _Int(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_Int left, _Int right) => left.INT() == right.INT();
            public static bool operator !=(_Int left, _Int right) => left.INT() != right.INT();
        }
        public sealed class _Short
        {
            private short shrt;
            public _Short(short value) => shrt = value;
            public short SHORT() => shrt;

            public static implicit operator short(_Short n) => n.SHORT();
            public static explicit operator _Short(short x) => new _Short(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_Short left, _Short right) => left.SHORT() == right.SHORT();
            public static bool operator !=(_Short left, _Short right) => left.SHORT() != right.SHORT();
        }
        public sealed class _Long
        {
            private long lng;
            public _Long(long value) => lng = value;
            public long LONG() => lng;

            public static implicit operator long(_Long n ) => n.LONG();
            public static explicit operator _Long(long x) => new _Long(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_Long left, _Long right) => left.LONG() == right.LONG();
            public static bool operator !=(_Long left, _Long right) => left.LONG() != right.LONG();
        }
        public sealed class _String
        {
            private string str;
            public _String(string value) => str = value;
            public string STRING() => str;

            public static implicit operator string(_String n) => n.STRING();
            public static explicit operator _String(string x) => new _String(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_String left, _String right) => left.STRING() == right.STRING();
            public static bool operator !=(_String left, _String right) => left.STRING() != right.STRING();
        }
        public sealed class _Double
        {
            private double dbl;
            public _Double(double value) => dbl = value;
            public double DOUBLE() => dbl;

            public static implicit operator double(_Double n) => n.DOUBLE();
            public static explicit operator _Double(double x) => new _Double(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_Double left, _Double right) => left.DOUBLE() == right.DOUBLE();
            public static bool operator !=(_Double left, _Double right) => left.DOUBLE() != right.DOUBLE();
        }
        public sealed class _Float
        {
            private float flt;
            public _Float(float value) => flt = value;
            public float FLOAT() => flt;

            public static implicit operator float(_Float n) => n.FLOAT();
            public static explicit operator _Float(float x) => new _Float(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_Float left, _Float right) => left.FLOAT() == right.FLOAT();
            public static bool operator !=(_Float left, _Float right) => left.FLOAT() != right.FLOAT();
        }
        public sealed class _Array<Type>
        {
            private Type[] array;
            public _Array(Type[] value) => array = value;
            public Type[] ARRAY() => array;

            public static implicit operator Type[](_Array<Type> n) => n.ARRAY();
            public static explicit operator _Array<Type>(Type[] x) => new _Array<Type>(x);
        }
        public sealed class _List<Type>
        {
            private List<Type> _list = new List<Type>();
            public _List(List<Type> value) => _list = value;
            public List<Type> LIST() => _list;

            public static implicit operator List<Type>(_List<Type> n) => n.LIST();
            public static explicit operator _List<Type>(List<Type> x) => new _List<Type>(x);
        }
        public sealed class _Byte
        {
            private byte byt;
            public _Byte(byte value) => byt = value;
            public byte BYTE() => byt;

            public static implicit operator byte(_Byte n) => n.BYTE();
            public static explicit operator _Byte(byte x) => new _Byte(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_Byte left, _Byte right) => left.BYTE() == right.BYTE();
            public static bool operator !=(_Byte left, _Byte right) => left.BYTE() != right.BYTE();
        }
        public sealed class _Bool
        {
            private bool bll;
            public _Bool(bool value) => bll = value;
            public bool BOOL() => bll;

            public static implicit operator bool(_Bool n) => n.BOOL();
            public static explicit operator _Bool(bool x) => new _Bool(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_Bool left, _Bool right) => left.BOOL() == right.BOOL();
            public static bool operator !=(_Bool left, _Bool right) => left.BOOL() != right.BOOL();
        }
        public sealed class _Null
        {
            private bool? nul;
            public _Null(bool? value) { if (value == null) { nul = value; } else { Console.WriteLine(Errors.Types.NullableError); } }
            public bool? NULL() => nul;

            public static implicit operator bool?(_Null n) => n.NULL();
            public static explicit operator _Null(bool? x) => new _Null(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_Null left, _Null right) => left.NULL() == right.NULL();
            public static bool operator !=(_Null left, _Null right) => left.NULL() != right.NULL();
        }
        public sealed class _Exception
        {
#pragma warning disable CS0649
            private Exception Except;
#pragma warning restore CS0649
            public _Exception(string except) { Except = new Exception(except); }
            public Exception EXCEPTION() => Except;

            public static implicit operator Exception(_Exception nE) => nE.EXCEPTION();
            public static explicit operator _Exception(string xE) => new _Exception(xE);
        }
        public sealed class _UInt
        {
            private uint value;
            public _UInt(uint val) => value = val;
            public uint UINT() => value;

            public static implicit operator uint(_UInt n) => n.UINT();
            public static explicit operator _UInt(uint x) => new _UInt(x);

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static bool operator ==(_UInt left, _UInt right) => left.UINT() == right.UINT();
            public static bool operator !=(_UInt left, _UInt right) => left.UINT() != right.UINT();
        }
        public sealed class _UFloat
        {
            private float uflt;
            public _UFloat(float value) { if (value > 0) { uflt = value; } else { Console.WriteLine(Errors.Types.UFloatError); } }
            public float UFLOAT() => uflt;

            public static implicit operator float(_UFloat n) => n.UFLOAT();
            public static explicit operator _UFloat(float x) => new _UFloat(x);
        }
        public sealed class _UShort
        {
            private short ushrt;
            public _UShort(short value) { if (value > 0) { ushrt = value; } else { Console.WriteLine(Errors.Types.UShortError); } }
            public short USHORT() => ushrt;

            public static implicit operator short(_UShort n) => n.USHORT();
            public static explicit operator _UShort(short x) => new _UShort(x);
        }
        public sealed class _ULong
        {
            private long ulng;
            public _ULong(long value) { if (value > 0) { ulng = value; } else { Console.WriteLine(Errors.Types.ULongError); } }
            public long ULONG() => ulng;

            public static implicit operator long(_ULong n) => n.ULONG();
            public static explicit operator _ULong(long x) => new _ULong(x);
        }
        public sealed class _UDouble
        {
            private double udbl;
            public _UDouble(double value) { if (value > 0) { udbl = value; } else { Console.WriteLine(Errors.Types.UDoubleError); } }
            public double UDOUBLE() => udbl;

            public static implicit operator double(_UDouble n) => n.UDOUBLE();
            public static explicit operator _UDouble(double x) => new _UDouble(x);
        }
        public sealed class _DynVar<Type>
        {
            private Type var;
            public _DynVar(Type value) { var = value; }
            public Type DYNVAR() => var;
            ~_DynVar() { /*Abstract actions : just suppress memory...*/ }

            public static implicit operator Type(_DynVar<Type> n) => n.DYNVAR();
            public static explicit operator _DynVar<Type>(Type x) => new _DynVar<Type>(x);
        }
        public sealed class _StaticVar<Type>
        {
            private Type var;
            public _StaticVar(Type value) { var = value; }
            public Type STATICVAR() => var;

            public static implicit operator Type(_StaticVar<Type> n) => n.STATICVAR();
            public static explicit operator _StaticVar<Type>(Type x) => new _StaticVar<Type>(x);
        }
        public sealed class _DynArray<Type>
        {
            private _Array<Type> dynArray;
            public _DynArray(_Array<Type> value) => dynArray = value;
            public _Array<Type> DYNARRAY() => dynArray;
            ~_DynArray() { /*just suppress memory, just wait...*/ }

            public static implicit operator _Array<Type>(_DynArray<Type> n) => n.DYNARRAY();
            public static explicit operator _DynArray<Type>(_Array<Type> x) => new _DynArray<Type>(x);

            public static implicit operator Type[](_DynArray<Type> n)
            {
                _Array<Type> subArray = new _Array<Type>(n);
                Type[] finalArray = (Type[])subArray;
                return finalArray;
            }
            public static explicit operator _DynArray<Type>(Type[] x)
            {
                _Array<Type> subArray = new _Array<Type>(x);
                _DynArray<Type> finalArray = new _DynArray<Type>(subArray);
                return finalArray;
            }
        }
        public sealed class _DynList<Type>
        {
            private _List<Type> _list;
            public _DynList(_List<Type> value) => _list = value;
            public _List<Type> DYNLIST() => _list;
            ~_DynList() { /*just suppress memory, just wait...*/ }

            public static implicit operator _List<Type>(_DynList<Type> n) => n.DYNLIST();
            public static explicit operator _DynList<Type>(_List<Type> x) => new _DynList<Type>(x);

            public static implicit operator List<Type>(_DynList<Type> n)
            {
                _List<Type> subList = new _List<Type>(n);
                List<Type> finalList = (List<Type>)subList;
                return finalList;
            }
            public static explicit operator _DynList<Type>(List<Type> x)
            {
                _List<Type> subList = new _List<Type>(x);
                _DynList<Type> finalList = new _DynList<Type>(subList);
                return finalList;
            }
        }        
    }
    public sealed class Log
    {
        private StreamWriter log;
        public Log(string logname, bool WriteMode = true)
        {
            if (File.Exists(logname) == true)
            {
                this.log = new StreamWriter("./"+logname, WriteMode);
            }
            else
            {
                System.IO.File.Create("./"+logname);
                this.log = new StreamWriter("./" + logname, WriteMode);
            }
        }
        public void Write(string message, bool WriteLine = true)
        {
            if (WriteLine)
            {
                this.log.WriteLine(message);
            }
            else if(WriteLine == false)
            {
                this.log.Write(message);
            }
            else
            {
                Console.WriteLine(Errors.Log.WriteLineValueException);
            }
        }
        public void Close()
        {
            this.log.Close();
        }
        ~Log() { /*abstract actions : suppress memory, just wait...*/ }
    }
    public sealed class FilesIO
    {
        public class Read
        {
            StreamReader fileToRead;
#pragma warning disable CS0649
            bool _exists;
#pragma warning restore CS0649
            public Read(string filepath)
            {
                if (File.Exists(filepath) == true)
                {
                    this.fileToRead = new StreamReader(filepath);
                }
                else
                {
                    System.IO.File.Create("./" + filepath);
                    this.fileToRead = new StreamReader(filepath);
                }
            }
            public string READ(StreamReader file)
            {
                if (this._exists)
                {
                    return file.ReadToEnd();
                }
                else
                {
                    Console.WriteLine(Errors.FilesIO.FileNotFound);
                    return "";
                }
            }
        }
        public class Write
        {
            StreamWriter fileToWrite;
#pragma warning disable CS0649
            bool _exists;
#pragma warning restore CS0649

            public Write(string filepath)
            {
                if (File.Exists(filepath))
                {
                    this.fileToWrite = new StreamWriter(filepath);
                }
                else
                {
                    System.IO.File.Create("./" + filepath);
                    this.fileToWrite = new StreamWriter(filepath);
                }
            }
            public bool WRITE(StreamWriter file, string message)
            {
                bool sucefull;
                if (this._exists)
                {
                    file.Write(message);
                    sucefull = true;
                    return sucefull;
                }
                else
                {
                    Console.WriteLine(Errors.FilesIO.FileNotFound);
                    sucefull = false;
                    return sucefull;
                }
            }
        }
    }

    public sealed class MapPosition
    {
        private struct CoordsCreator
        {
            public int abs { get; set; }
            public int ord { get; set; }
        }
        
        CoordsCreator Coords;

        /// <summary>
        /// Créer une nouvelle instance de la classe MapPosition avec des coordonnées aléatoires.
        /// </summary>
        /// <param name="map">L'instance de la classe Map à préciser.</param>
        public MapPosition(Map map)
        {
            Random rdm = new Random();
            Coords = new CoordsCreator { abs = rdm.Next(map.PublicCoords[0]), ord = rdm.Next(map.PublicCoords[2]) };
            map.Positions.Add("(" + Coords.abs.ToString() + ";" + Coords.ord.ToString() + ")");
        }
        /// <summary>
        /// Créer une nouvelle instance de la classe MapPosition avec une coordonnée aléatoire comprise entre 1 et 100.
        /// </summary>
        /// <param name="coord">La valeur de la coordonée non aléatoire.</param>
        /// <param name="position">Si "true", alors les ordonnées seront aléatoires | Si "false", alors les abscisses seront aléatoires.</param>
        /// <param name="map">L'instance de la classe Map à préciser.</param>
        public MapPosition(int coord, bool position, Map map)
        {
            Random rdm = new Random();
            if (position == true)
                if (coord <= map.PublicCoords[0])
                    Coords = new CoordsCreator { abs = coord, ord = rdm.Next(map.PublicCoords[2]) };
                else
                    Coords = new CoordsCreator { abs = map.PublicCoords[0], ord = rdm.Next(map.PublicCoords[2]) };
            else
                if (coord <= map.PublicCoords[2])
                Coords = new CoordsCreator { abs = rdm.Next(map.PublicCoords[0]), ord = coord };
            else
                Coords = new CoordsCreator { abs = rdm.Next(map.PublicCoords[0]), ord = map.PublicCoords[2] };

            map.Positions.Add("(" + Coords.abs.ToString() + ";" + Coords.ord.ToString() + ")");
        }
        /// <summary>
        /// Créer une nouvelle instance de la classe MapPosition.
        /// </summary>
        /// <param name="x">Valeur des abscisses.</param>
        /// <param name="y">Valeur des ordonnées.</param>
        /// <param name="map">L'instance de la classe Map à préciser.</param>
        public MapPosition(int x, int y, Map map)
        {
            if (x <= map.PublicCoords[0])
                if (y <= map.PublicCoords[2])
                    Coords = new CoordsCreator { abs = x, ord = y};
                else
                    Coords = new CoordsCreator { abs = x, ord = map.PublicCoords[2] };
            else
                if (y <= map.PublicCoords[2])
                    Coords = new CoordsCreator { abs = map.PublicCoords[0], ord = y };
                else
                    Coords = new CoordsCreator { abs = map.PublicCoords[0], ord = map.PublicCoords[2] };

            map.Positions.Add("(" + Coords.abs.ToString() + ";" + Coords.ord.ToString() + ")");
        }

        public bool CompareTo(MapPosition x, MapPosition y)
        {
            if ((x.Coords.abs + x.Coords.ord) == (y.Coords.abs + y.Coords.ord))
                return true;
            else
                return false;
        }
        public int CalcDifference(MapPosition x, MapPosition y)
        {
            int difference = (x.Coords.abs + x.Coords.ord) - (y.Coords.abs + y.Coords.ord);
            return difference;
        }
        public int AddCoords(MapPosition x, MapPosition y)
        {
            int add = (x.Coords.abs + x.Coords.ord) + (y.Coords.abs + y.Coords.ord);
            return add;
        }
        public int AddCoords(MapPosition x)
        {
            int add = x.Coords.abs + x.Coords.ord;
            return add;
        }
        public int GetHashCode(MapPosition x)
        {
            return x.Coords.abs * x.Coords.ord;
        }
        public int GetHashCode(MapPosition x, MapPosition y)
        {
            return (x.Coords.abs * x.Coords.ord) * (y.Coords.abs * y.Coords.ord);
        }
        public string ToString(MapPosition x)
        {
            string str = "(";
            str += x.Coords.abs.ToString();
            str += ";";
            str += x.Coords.ord.ToString();
            str += ")";
            return str;
        }
        public string ToString(MapPosition x, MapPosition y)
        {
            string str = "[";
            str += this.ToString(x);
            str += ";";
            str += this.ToString(y);
            return str;
        }
        public int[] ToArray(MapPosition x)
        {
            int[] Array = new int[2];
            Array[0] = x.Coords.abs;
            Array[1] = x.Coords.ord;
            return Array;
        }
        public int[] ToArray(MapPosition x, MapPosition y)
        {
            int[] Array = new int[4];

            Array[0] = x.Coords.abs;
            Array[1] = x.Coords.ord;

            Array[2] = y.Coords.abs;
            Array[3] = y.Coords.ord;

            return Array;
        }
        public MapPosition ChangeCoords(int[] coords, Map map)
        {
            return new MapPosition(coords[0], coords[1], map);
        }
    }
    public sealed class Map
    {
        private struct CoordsCreator
        {
            public int PositiveMaxAbs { get; set; }
            public int NegativeMaxAbs { get; set; }
            public int PositiveMaxOrd { get; set; }
            public int NegativeMaxOrd { get; set; }
        }

        CoordsCreator Coords;

        public int[] PublicCoords = new int[4];

        /// <summary>
        /// Créer une instance de la classe Map.
        /// </summary>
        /// <param name="px">Valeur positive maximale des abscisses.</param>
        /// <param name="nx">Valeur négative maximale des abscisses.</param>
        /// <param name="py">Valeur positive maximale des ordonnées.</param>
        /// <param name="ny">Valeur négative maximale des ordonnées.</param>
        public Map(int px, int nx, int py, int ny)
        {
            Coords = new CoordsCreator { PositiveMaxAbs = px, NegativeMaxAbs = nx, PositiveMaxOrd = py, NegativeMaxOrd = ny };
            PublicCoords[0] = px;
            PublicCoords[1] = nx;
            PublicCoords[2] = py;
            PublicCoords[3] = ny;
        }

        /// <summary>
        /// Liste contenant les points de la carte (instance de la classe Map), les points étants des instances de MapPosition.
        /// </summary>
        public List<string> Positions = new List<string>();

        public int GetHashCode(Map map)
        {
            int hash;
            hash = ((map.PublicCoords[0] * map.PublicCoords[1]) * (map.PublicCoords[2] * map.PublicCoords[3]));
            return hash;
        }
        public bool CompareHash(Map x, Map y)
        {
            if (GetHashCode(x) == GetHashCode(y))
                return true;
            else
                return false;
        }
    }

    public sealed class SpaceMapPosition
    {
        private struct CoordsCreator
        {
            public int abs { get; set; }
            public int ord { get; set; }
            public int alt { get; set; }
        }

        CoordsCreator Coords;

        public int[] PublicCoords = new int[3];

        /// <summary>
        /// Créer une nouvelle instance de la classe SpaceMapPosition avec des coordonnées aléatoires.
        /// </summary>
        /// <param name="map">L'instance de la classe SpaceMap à préciser.</param>
        public SpaceMapPosition(SpaceMap map)
        {
            Random rdm = new Random();
            Coords = new CoordsCreator { abs = rdm.Next(map.PublicCoords[0]), ord = rdm.Next(map.PublicCoords[2]), alt = rdm.Next(map.PublicCoords[4]) };

            PublicCoords[0] = Coords.abs;
            PublicCoords[1] = Coords.ord;
            PublicCoords[2] = Coords.alt;

            map.Positions.Add("(" + Coords.abs.ToString() + ";" + Coords.ord.ToString() + ";" + Coords.alt.ToString() + ")");
        }
        /// <summary>
        /// Créer une nouvelle instance de la classe SpaceMapPosition avec une coordonnée aléatoire comprise entre 1 et 100.
        /// </summary>
        /// <param name="coord1">La valeur de la première coordonnée non aléatoire.</param>
        /// <param name="coord2">La valeur de la deuxième coordonnée non aléatoire.</param>
        /// <param name="position">Si "0", alors les ordonnées seront aléatoires | Si "1", alors les abscisses seront aléatoires. | Si "3", alors les altitudes seront aléatoires.</param>
        /// <param name="map">L'instance de la classe SpaceMap à préciser.</param>
        public SpaceMapPosition(int coord1, int coord2, short position, SpaceMap map)
        {
            Random rdm = new Random();
            if (position == 0)
            {
                if (coord1 <= map.PublicCoords[0] && coord2 <= map.PublicCoords[4])
                    Coords = new CoordsCreator { abs = coord1, ord = rdm.Next(map.PublicCoords[2]), alt = coord2 };
                else
                    Coords = new CoordsCreator { abs = map.PublicCoords[0], ord = rdm.Next(map.PublicCoords[2]), alt = map.PublicCoords[4] };
            }
            else if (position == 1)
            {
                if (coord1 <= map.PublicCoords[2] && coord2 <= map.PublicCoords[4])
                    Coords = new CoordsCreator { abs = rdm.Next(map.PublicCoords[0]), ord = coord1, alt = coord2 };
                else
                    Coords = new CoordsCreator { abs = rdm.Next(map.PublicCoords[0]), ord = map.PublicCoords[2], alt = map.PublicCoords[4] };
            }
            else
            {
                if (coord1 <= map.PublicCoords[0] && coord2 <= map.PublicCoords[2])
                    Coords = new CoordsCreator { abs = coord1, ord = coord2, alt = rdm.Next(map.PublicCoords[4]) };
                else
                    Coords = new CoordsCreator { abs = map.PublicCoords[0], ord = map.PublicCoords[2], alt = map.PublicCoords[4] };
            }

            PublicCoords[0] = Coords.abs;
            PublicCoords[1] = Coords.ord;
            PublicCoords[2] = Coords.alt;

            map.Positions.Add("(" + Coords.abs.ToString() + ";" + Coords.ord.ToString() + ";" + Coords.alt.ToString() +")");
        }
        /// <summary>
        /// Créer une nouvelle instance de la classe SpaceMapPosition.
        /// </summary>
        /// <param name="x">Valeur des abscisses.</param>
        /// <param name="y">Valeur des ordonnées.</param>
        /// <param name="z">Valeur des altitudes.</param>
        /// <param name="map">L'instance de la classe SpaceMap à préciser.</param>
        public SpaceMapPosition(int x, int y, int z, SpaceMap map)
        {
            if (x <= map.PublicCoords[0])
            {
                if (y <= map.PublicCoords[2])
                {
                    if (z <= map.PublicCoords[4])
                        Coords = new CoordsCreator { abs = x, ord = y, alt = z };
                    else
                        Coords = new CoordsCreator { abs = x, ord = y, alt = map.PublicCoords[4] };
                }
                else
                {
                    if (z <= map.PublicCoords[4])
                        Coords = new CoordsCreator { abs = x, ord = map.PublicCoords[2], alt = z };
                    else
                        Coords = new CoordsCreator { abs = x, ord = map.PublicCoords[2], alt = map.PublicCoords[4] };
                }
            }
            else
            {
                if (y <= map.PublicCoords[2])
                {
                    if (z <= map.PublicCoords[4])
                        Coords = new CoordsCreator { abs = map.PublicCoords[0], ord = y, alt = z };
                    else
                        Coords = new CoordsCreator { abs = map.PublicCoords[0], ord = y, alt = map.PublicCoords[4] };
                }
                else
                {
                    if (z <= map.PublicCoords[4])
                        Coords = new CoordsCreator { abs = map.PublicCoords[0], ord = map.PublicCoords[2], alt = z };
                    else
                        Coords = new CoordsCreator { abs = map.PublicCoords[0], ord = map.PublicCoords[2], alt = map.PublicCoords[4] };
                }
            }

            PublicCoords[0] = Coords.abs;
            PublicCoords[1] = Coords.ord;
            PublicCoords[2] = Coords.alt;

            map.Positions.Add("(" + Coords.abs.ToString() + ";" + Coords.ord.ToString() + ")");
        }

        public bool CompareTo(SpaceMapPosition x, SpaceMapPosition y)
        {
            if (GetHashCode(x) == GetHashCode(y))
                return true;
            else
                return false;
        }
        public int CalcDiffernce(SpaceMapPosition x, SpaceMapPosition y)
        {
            return (x.Coords.abs + x.Coords.ord + x.Coords.alt) - (y.Coords.abs + y.Coords.ord + y.Coords.alt);
        }
        public int AddCoords(SpaceMapPosition x, SpaceMapPosition y)
        {
            return (x.Coords.abs + x.Coords.ord + x.Coords.alt) + (y.Coords.abs + y.Coords.ord + y.Coords.alt);
        }
        public int AddCoords(SpaceMapPosition x)
        {
            return x.Coords.abs + x.Coords.ord + x.Coords.alt;
        }
        public int GetHashCode(SpaceMapPosition x)
        {
            return x.Coords.abs * x.Coords.ord * x.Coords.alt;
        }
        public int GetHashCode(SpaceMapPosition x, SpaceMapPosition y)
        {
            return GetHashCode(x) * GetHashCode(y);
        }
        public string ToString(SpaceMapPosition x)
        {
            string str = "(";
            str += x.Coords.abs.ToString();
            str += ";";
            str += x.Coords.ord.ToString();
            str += ";";
            str += x.Coords.alt.ToString();
            str += ")";
            return str;
        }
        public string ToString(SpaceMapPosition x, SpaceMapPosition y)
        {
            string str = "[";
            str += this.ToString(x);
            str += ";";
            str += this.ToString(y);
            return str;
        }
        public int[] ToArray(SpaceMapPosition x)
        {
            return new int[3] {x.Coords.abs, x.Coords.ord, x.Coords.alt };
        }
        public int[] ToArray(SpaceMapPosition x, SpaceMapPosition y)
        {
            return new int[6] { x.Coords.abs, x.Coords.ord, x.Coords.alt, y.Coords.abs, y.Coords.ord, y.Coords.alt };
        }
        public SpaceMapPosition ChangeCoords(int[] coords, SpaceMap map)
        {
            return new SpaceMapPosition(coords[0], coords[1], coords[2], map);
        }
    }
    public sealed class SpaceMap
    {
        private struct CoordsCreator
        {
            public int PositiveMaxAbs { get; set; }
            public int NegativeMaxAbs { get; set; }
            public int PositiveMaxOrd { get; set; }
            public int NegativeMaxOrd { get; set; }
            public int PositiveMaxAlt { get; set; }
            public int NegativeMaxAlt { get; set; }
        }

        CoordsCreator Coords;

        public int[] PublicCoords = new int[4];

        /// <summary>
        /// Créer une instance de la classe SpaceMap.
        /// </summary>
        /// <param name="px">Valeur positive maximale des abscisses.</param>
        /// <param name="nx">Valeur négative maximale des abscisses.</param>
        /// <param name="py">Valeur positive maximale des ordonnées.</param>
        /// <param name="ny">Valeur négative maximale des ordonnées.</param>
        /// <param name="pz">Valeur positive maximale des altitudes.</param>
        /// <param name="nz">Valeur négative maximale des altitudes.</param>
        public SpaceMap(int px, int nx, int py, int ny, int pz, int nz)
        {
            Coords = new CoordsCreator { PositiveMaxAbs = px, NegativeMaxAbs = nx, PositiveMaxOrd = py, NegativeMaxOrd = ny, PositiveMaxAlt = pz, NegativeMaxAlt = nz };
            PublicCoords[0] = px;
            PublicCoords[1] = nx;
            PublicCoords[2] = py;
            PublicCoords[3] = ny;
            PublicCoords[4] = pz;
            PublicCoords[5] = nz;
        }

        /// <summary>
        /// Liste contenant les points de la carte en volume (instance de la classe SpaceMap), les points étants des instances de SpaceMapPosition.
        /// </summary>
        public List<string> Positions = new List<string>();

        public int GetHashCode(SpaceMap map)
        {
            int hash;
            hash = ((map.PublicCoords[0] * map.PublicCoords[1]) * (map.PublicCoords[2] * map.PublicCoords[3]) * (map.PublicCoords[4] * map.PublicCoords[5]));
            return hash;
        }
        public bool CompareHash(SpaceMap x, SpaceMap y)
        {
            if (GetHashCode(x) == GetHashCode(y))
                return true;
            else
                return false;
        }
    }

    public sealed class MemoryManagement
    {
        
    }
}