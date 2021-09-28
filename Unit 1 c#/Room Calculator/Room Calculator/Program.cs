using System;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //start message
            Console.WriteLine("Welcome to the room calculator.");

            bool RunProgram = true;

            while (RunProgram == true)
            {
                //Getting inputs
                Console.WriteLine("What is the length of the room?");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the width of the room?");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the height of the room?");
                double height = double.Parse(Console.ReadLine());

                //Math
                double area = width * length;
                double perimeter = (width + length) * 2;
                double volume = length * height * width;
                double paint = perimeter / 5;
                double carpet = area / 5;

                //Display results
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine($"Paint: {paint}");
                Console.WriteLine($"Carpet: {carpet}");

                //Ask if keep looping
                bool checkInput = true;
                while (checkInput == true)
                {
                    Console.WriteLine("Would you like to keep going? y/n");
                    //.ToLower() takes string and lowercases it. .ToUpper() does uppercase
                    string result = Console.ReadLine().ToLower();

                    if (result == "n")
                    {
                        RunProgram = false;
                        checkInput = false;
                    }
                    else if (result == "y")
                    {
                        RunProgram = true;
                        checkInput = false;
                    }
                }
            }
        }
    }
}
