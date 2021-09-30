using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a string");
            string input = Console.ReadLine();

            //testing methods
            Console.WriteLine(UpperCase(input));
            Console.WriteLine(lowercase(input));
            Console.WriteLine(ReplaceFirstLetter(input, "X"));
            Console.WriteLine(SwitchHalves(input));
            Console.WriteLine(ReplaceLastLetter(input, "X"));
            Console.WriteLine(MoveFirstToLast(input));
        }

        public static string UpperCase(string x)
        {
            return x.ToUpper();
        }

        public static string lowercase(string x)
        {
            return x.ToLower();
        }

        public static string ReplaceFirstLetter(string x, string replace)
        {
            string result = x.Substring(1);
            return replace + result;
        }

        public static string SwitchHalves(string x)
        {
            //This is a sentence
            // sentence
            string result = x.Substring(x.Length / 2);
            //This is a
            string result2 = x.Substring(0, x.Length / 2);
            return result + result2;
        }

        public static string ReplaceLastLetter(string x, string replace)
        {
            //This is a sentenc
            string result = x.Substring(0, x.Length -1);
            return result + replace;
        }

        public static string MoveFirstToLast(string x)
        {
            string firstLetter = x.Substring(0, 1);
            string result = x.Substring(1);
            return result + firstLetter;
        }
    }
}
