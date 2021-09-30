using System;
using System.Text;

namespace Day3_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Justin";
            EditName(ref myName);
            string result = ReturnHelloUser(myName, 24);
            Console.WriteLine(result);
            string result1 = ReturnHelloUser();
            Console.WriteLine(result1);
            string result2 = ReturnHelloUser("zcvcvxz", 24);
            Console.WriteLine(result2);
            string result3 = ReturnHelloUser("adsfdsa", 24);
            Console.WriteLine(result3);

            //pass by out
            int x = 0;
            int y = 0;

            x = getByOutExample(out y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            //call string section
            stringSection();

            Console.WriteLine(getRandomNumber());

            countRandom();
        }

        public static void countRandom()
        {
            Random random = new Random();
            int number = random.Next(100) + 1;
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static int getRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(10)+1;
            return number;
        }

        //everything relating to strings
        public static void stringSection()
        {
            string x = "abc";
            string y = "ABC";

            if(x == y)
            {
                Console.WriteLine($"{x} is equal to {y} using ==");
            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y} using ==");
            }

            if(string.Compare(x,y) == 0)
            {
                Console.WriteLine($"{x} and {y} are comparable");
            }
            else
            {
                Console.WriteLine($"{x} and {y} are not comparable");
            }

            if (x.Equals(y))
            {
                Console.WriteLine($"{x} equals {y} using equals method");
            }
            else
            {
                Console.WriteLine($"{x} does not equal {y} using equals method");
            }

            Console.WriteLine($"{x} The letter b is in spot {x.IndexOf("b")} ");
            string z = "abcabcabc";
            Console.WriteLine($"{z} The letter b last appears in spot {z.LastIndexOf("b")}");
            Console.WriteLine($"{z} Does this end in a c? {z.EndsWith("c")}");
            string newZ = z.Replace("a", "j");
            Console.WriteLine(newZ);

            string sentence = "Welcome to my class";
            string[] words = sentence.Split(" ");
            foreach(string w in words)
            {
                Console.WriteLine(w);
            }

            Console.WriteLine($"{sentence.Substring(8)}");

            Console.WriteLine($"{sentence.ToUpper()}");
            Console.WriteLine($"{sentence.ToLower()}");

            string messyString = "                        Justin                           ";
            Console.WriteLine($"|{messyString}|");
            Console.WriteLine($"|{messyString.Trim()}|");


            //String Builder example

            StringBuilder sb = new StringBuilder("Test!");
            sb.Append("\t Super!");
            
            Console.WriteLine(sb);
        }

        //pass by out
        public static int getByOutExample(out int result2)
        {
            result2 = 2;
            return 1;
        }


        //pass by ref
        public static void EditName(ref string name)
        {
            name = "hklsfdahkjlasfdh";
        }

        public static string ReturnHelloUser(string name)
        {
            string greeting = $"Hello, {name}";
            return greeting;
        }

        public static string ReturnHelloUser()
        {
            string greeting = "Hello default user";
            return greeting;
        }

        public static string ReturnHelloUser(string name, int age)
        {
            string greeting = $"Hello, {name}. You are {age} years old.";
            return greeting;
        }
    }
}
