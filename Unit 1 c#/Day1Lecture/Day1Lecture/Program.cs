using System;

namespace Day1Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            const double taxRate = 0.07;

            /* Name: Justin
             * Date: 9/27/2021
             * Time: 10:03 am
             */
            Console.WriteLine("Hello World!");
            Console.WriteLine("Justin");
            //Getting User Input Below
            string input = Console.ReadLine();
            Console.WriteLine(input);

            int FavoriteNumber = 30;
            FavoriteNumber /= 100;

            //Convert string to number
            Console.WriteLine("Enter a radius");
            string entry = Console.ReadLine();
            double value = double.Parse(entry);
            double area = Math.PI * value * value;
            Console.WriteLine(area);


            //casting
            int x = 5;
            double y = 10.5;
            //Implicit casting
            double z = x + y;
            Console.WriteLine(z);
            //Explicit casting
            int w = x + (int)y;
            Console.WriteLine(w);

            //Exercise
            Console.WriteLine("Please enter the first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number");
            double num3 = double.Parse(Console.ReadLine());

            double total = num1 + num2 + num3;
            double average = total / 3;

            Console.WriteLine("The average of the numbers is: " + average);
        }
    }
}
