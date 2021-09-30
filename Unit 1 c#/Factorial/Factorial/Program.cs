using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1-10");
            int num = int.Parse(Console.ReadLine());
            long result = factorial(num);
            Console.WriteLine(result);
        }

        public static long factorial(int loops)
        {
            long total = 1;
            for(int i = 1; i<= loops; i++)
            {
                total *= i;
            }
            return total;
        }
    }
}
