using System;
using System.Collections.Generic;
using System.Text;

namespace CircleLab
{
    class Validator
    {
        public static double getRadius()
        {
            double result = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a radius.");
                    result = double.Parse(Console.ReadLine());
                    if (result <= 0)
                    {
                        Console.WriteLine("Please enter a number above 0");
                    }
                    else
                    {
                        //correct
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a number");
                }
            }

            return result;
        }

        public static bool getContinue()
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine("Would you like to create another circle? y/n");
                string choice = Console.ReadLine().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid input");
                }
            }

            return result;
        }

    }
}
