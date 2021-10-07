using System;

namespace Casino_Dice_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Casino Dice Roller.");
            bool runProgram = true;
            while (runProgram)
            {
                int sides = getSides();
                int num1 = rollDice(sides);
                int num2 = rollDice(sides);
                Console.WriteLine($"You rolled a {num1} and a {num2}! ({num1 + num2} total)");
                if (sides == 6)
                {
                    //class version
                    DiceRollerApp.DisplayCombinations(num1, num2);
                    //main program version
                    //DisplayCombinations(num1, num2);
                }

                runProgram = GetContinue();
            }

            //test
            /*
            //snake eyes and craps
            DisplayCombinations(1, 1);
            //Ace deuce and crap
            DisplayCombinations(1, 2);
            DisplayCombinations(2, 1);
            //boxcars and craps
            DisplayCombinations(6, 6);
            //win
            DisplayCombinations(6, 1);
            DisplayCombinations(6, 5);
            */
        }

        static bool GetContinue()
        {
            bool result = true;

            while(true)
            {
                Console.WriteLine("Would you like to roll more dice? y/n");
                string input = Console.ReadLine().ToLower();
                if(input == "y")
                {
                    result = true;
                    break;
                }
                else if (input == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That wasn't a valid input.");
                }
            }

            return result;
        }

        static void DisplayCombinations(int num1, int num2)
        {
            //dice combos
            if (num1 == 1 && num2 == 1)
            {
                Console.WriteLine(combinations.Snake_Eyes);
            }
            else if (num1 == 1 && num2 == 2)
            {
                Console.WriteLine(combinations.Ace_Deuce);
            }
            else if (num1 == 2 && num2 == 1)
            {
                Console.WriteLine(combinations.Ace_Deuce);
            }
            else if (num1 == 6 && num2 == 6)
            {
                Console.WriteLine(combinations.Box_Cars);
            }

            //dice totals
            int total = num1 + num2;
            if (total == 7 || total == 11)
            {
                Console.WriteLine(combinations.Win);
            }
            else if (total == 2 || total == 3 || total == 12)
            {
                Console.WriteLine(combinations.Craps);
            }

        }

        static int rollDice(int sides)
        {
            Random r = new Random();
            return r.Next(1, sides + 1);
        }

        static int getSides()
        {
            //get user input, make sure its valid
            int sides = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("How many sides should each dice have?");
                    sides = int.Parse(Console.ReadLine());
                    if (sides <= 0)
                    {
                        throw new Exception("You entered a number that is too low.");
                    }
                    else
                    {
                        //Valid input
                        break;
                    }
                }
                //if its a string
                catch (FormatException e)
                {
                    Console.WriteLine("That wasn't a valid input.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return sides;
        }


    }
}
