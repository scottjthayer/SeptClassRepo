using System;

namespace CircleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");

            //CircleTester();
            bool runProgram = true;
            int circleCount = 0;

            while (runProgram)
            {
                //Ask for a radius
                double radius = Validator.getRadius();
                Circle c = new Circle(radius);
                circleCount++;

                Console.WriteLine($"area: {c.CalculateFormattedArea()}");
                Console.WriteLine($"circumference: {c.CalculateFormattedCircumference()}");

                //get continue
                runProgram = Validator.getContinue();
            }

            Console.WriteLine("Thanks for using the Circle Tester");
            Console.WriteLine($"You created {circleCount} circles");
        }

        static void CircleTester()
        {
            Circle c = new Circle(5);
            
            Console.WriteLine(c.CalculateCircumference());
            Console.WriteLine(c.CalculateArea());
            Console.WriteLine(c.CalculateFormattedCircumference());
            Console.WriteLine(c.CalculateFormattedArea());
        }

        //static bool getContinue()
        //{
        //    bool result = true;

        //    while (true)
        //    {
        //        Console.WriteLine("Would you like to create another circle? y/n");
        //        string choice = Console.ReadLine().ToLower();
        //        if(choice == "y")
        //        {
        //            result = true;
        //            break;
        //        }
        //        else if(choice == "n")
        //        {
        //            result = false;
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("That was not a valid input");
        //        }
        //    }

        //    return result;
        //}

        //static double getUserRadius()
        //{
        //    double result = 0;


        //    while (true)
        //    {
        //        try
        //        {
        //            Console.WriteLine("Please enter a radius.");
        //            result = double.Parse(Console.ReadLine());
        //            if (result <= 0)
        //            {
        //                Console.WriteLine("Please enter a number above 0");
        //            }
        //            else
        //            {
        //                //correct
        //                break;
        //            }
        //        }
        //        catch (FormatException e)
        //        {
        //            Console.WriteLine("That was not a number");
        //        }
        //    }

        //    return result;

        //}


    }
}
