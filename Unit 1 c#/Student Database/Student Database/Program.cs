using System;

namespace Student_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names =
            {
                "Justin",
                "Matt",
                "Logan",
                "Raston",
                "Yousif",
                "Yash",
                "Chris",
                "Radeen",
                "Josh",
                "Aron",
                "Kasean",
                "Scott",
                "Delmar",
                "Brandon"
            };

            string[] hometown =
            {
                "Wyoming,MI",
                "Flint,MI",
                "Plymouth,MI",
                "Zeeland, MI",
                "Oak Park, MI",
                "Detroit,MI",
                "Novi",
                "Warren, MI",
                "Northville",
                "Berea, KY",
                "Detroit, MI",
                "Lansing, MI",
                "Detroit,Mi",
                "Novi"
            };

            string[] foods =
            {
                 "Baja Blast",
                 "Hot Wings",
                 "Fuyuns",
                 "Vanilla Instant Pudding",
                 "Deep Dish Pizza",
                 "Hot Cheeto Puffs",
                 "Tacos",
                 "Mexican",
                 "Naleśniki",
                 "sushi",
                 "steak",
                 "Nashville Chicken",
                 "vietnamese food",
                 "Sushi"
            };

            //-----------------------------------------------
            //Start of program
            Console.WriteLine("Welcome to the student database.");

            //loop program
            bool runProgram = true;
            while(runProgram)
            {
                int id = getStudentId(names);
                Console.WriteLine($"That student is {names[id]}");
                getExtraDetail(names, hometown, foods, id);
                runProgram = getContinueLoop();
            }
        }

        static bool getContinueLoop()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine("Would you like to continue? y/n");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    //continue
                    result = true;
                    break;
                }
                else if (input == "n")
                {
                    //stop
                    result = false;
                    break;
                }
                else
                {
                    //something else
                    Console.WriteLine("Please choose a valid input");
                }
            }
            return result;
        }

        static void getExtraDetail(string[] names, string[] hometown, string[] food, int id)
        {
            while(true)
            {
                Console.WriteLine("What would you like to know about them? (enter 'hometown' or 'favfood')");
                string input = Console.ReadLine().ToLower();

                if(input == "hometown")
                {
                    //hometown
                    Console.WriteLine($"{names[id]} is from {hometown[id]}");
                    break;
                }
                else if (input == "favfood")
                {
                    //food
                    Console.WriteLine($"{names[id]}'s favorite food is {food[id]}");
                    break;
                }
                else
                {
                    //something else
                    Console.WriteLine("That was not a valid choice.");
                }
            }
        }

        static int getStudentId(string[] names)
        {
            int input = 0;
            while (true)
            {
                Console.WriteLine($"Please enter a number between 1 - {names.Length}. You can also search by name.");
                //search by name first
                string search = Console.ReadLine();
                for(int i = 0; i< names.Length; i++)
                {
                    if(search.ToLower() == names[i].ToLower())
                    {
                        //minus 1 to target the index. Return stops it early
                        return i;
                    }
                }

                input = int.Parse(search);
                //outdated. extended changes this \/
                //input = int.Parse(Console.ReadLine());
                if (input <= names.Length && input >= 1)
                {
                    //within range
                    break;
                }
                else
                {
                    Console.WriteLine("That number was not in range");
                }
            }

            //minus 1 to target the index
            return input - 1;
        }


    }
}
