using System;

namespace Day2Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Vustin";
            int age = 245;

            //if statment using AND
            if(name == "Justin" && age == 24)
            {
                Console.WriteLine("Welcome master!");
            }
            else if (name == "Justin" || age == 24)
            {
                Console.WriteLine("You almost got me");
            }
            else
            {
                Console.WriteLine("Get off my computer theif");
            }

            if(age > 70)
            {
                Console.WriteLine("You are old. Go to the retirement home");
            }

            //cleaner if statement
            if(age >= 21)
            {
                Console.WriteLine("You can drink");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else if (age >= 16)
            {
                Console.WriteLine("You can drive");
            }

            //Nested if statements
            if(age >= 16)
            {
                Console.WriteLine("You are able to drive.");
                if(age >= 18)
                {
                    Console.WriteLine("You are able to vote.");
                    if (age >= 21)
                    {
                        Console.WriteLine("You are able to drink.");
                    }
                    else
                    {
                        Console.WriteLine("You are not able to drink");
                    }
                }
                else
                {
                    Console.WriteLine("You are not able to vote.");
                }
            }
            else
            {
                Console.WriteLine("You are too young to drive.");
            }

            //Switch
            Console.WriteLine("What is your Program Manager's name? Kam/Tommy/Carmen/Logan");
            string switchChoice = Console.ReadLine();
            switch (switchChoice)
            {
                case "Kam":
                    Console.WriteLine("Kam was not the right choice.");
                    break;
                case "Tommy":
                    Console.WriteLine("Tommy was not the right choice.");
                    break;
                case "Karmen":
                    Console.WriteLine("Karmen was the right choice.");
                    break;
                case "Logan":
                    Console.WriteLine("Logan was not the right choice. He is a student");
                    break;
                default:
                    Console.WriteLine("That was not a choice.");
                    break;
            }

            //while loop
            bool whileCheck = true;
            while(whileCheck == true)
            {
                Console.WriteLine("While check is true");
                Console.WriteLine("Press y to stop");
                string whileResult = Console.ReadLine();
                if (whileResult == "y")
                {
                    whileCheck = false;
                }
            }

            //do while loop
            bool doWhileCheck = true;
            do
            {
                Console.WriteLine("Inside do while loop");
                Console.WriteLine("Press y to stop");
                string doWhileResult = Console.ReadLine();
                if (doWhileResult == "y")
                {
                    doWhileCheck = false;
                }
            } while (doWhileCheck == true);

            //for loop
            for(int i = 0; i <=10; i++)
            {
                Console.WriteLine(i);
            }

            //foreach
            int[] numbers = { 10, 20, 30, 40, 50, 1, 1000000000, -5 };
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }

            //break
            while(true)
            {
                Console.WriteLine(true);
                Console.WriteLine("Would you like to escape the infinite loop? y/n");
                string breakResult = Console.ReadLine();
                if(breakResult == "y")
                {
                    break;
                }
            }

            //continue
            do
            {
                Console.WriteLine("Would you like to escape the second infinite loop? y/n");
                string continueResult = Console.ReadLine();
                if(continueResult == "y")
                {
                    break;
                }
                else if (continueResult == "n")
                {
                    continue;
                }

                Console.WriteLine("you didn't choose one of the options.");
            } while (true);
        }
    }
}
