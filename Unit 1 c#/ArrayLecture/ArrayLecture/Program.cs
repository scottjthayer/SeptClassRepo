using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring and Instantiating Arrays
            string[] titles = new string[3];

            double[] prices;
            prices = new double[4];

            int population = 329000000;
            bool[] IsVaccinated = new bool[population];

            //giving array's values
            double[] favNumbers = { 420, 69, 0, 1, 961 };

            favNumbers[0] = 100;
            favNumbers[1] = 22;
            favNumbers[2] = 9.87;
            favNumbers[4] = 21;

            //using single element
            Console.WriteLine($"My favorite number is {favNumbers[0]}");
            double result = favNumbers[0];

            //looping through arrays
            //for loop
            string[] snacks = { 
                "Doritos",
                "Baja blast",
                "Chips and Salsa",
                "jerky",
                "sour gummy worms",
                "vanilla instant pudding",
                "Funyuns",
                "hot cheeto puffs",
                "chocolate covered honeybuns",
                "hot wings",
                "met-rx bar",
                "white cheddar hippeas",
                "Doritos",
                "barbecue chips",
                "Starbucks Frappe"
            };

            for(int i = 0; i < snacks.Length; i++)
            {
                Console.WriteLine(snacks[i]);
            }

            //adding all numbers up using for loop
            double total = 0;
            for(int i = 0; i< favNumbers.Length; i++)
            {
                total += favNumbers[i];
            }
            double average = total / favNumbers.Length;
            Console.WriteLine($"The average of your favorite numbers is {average}");

            //looping through arrays
            //foreach
            string[] names = {
                "Justin",
                "Aron",
                "Brandon",
                "Chris",
                "Delmar",
                "Josh",
                "Kasean",
                "Logan",
                "Matt",
                "Radeen",
                "Raston",
                "Scott",
                "Yash",
                "Yousif"
            };

            foreach(string n in names)
            {
                Console.WriteLine(n);
            }

            double sum = 0;
            foreach(double num in favNumbers)
            {
                sum += num;
            }
            double avg = sum / favNumbers.Length;
            Console.WriteLine($"The average of your favorite numbers is {avg}");

            //referencing arrays
            int[] ages = { 21, 24, 36, 46, 56 };
            int[] agesRef = ages;
            agesRef[0] = 70;

            Console.WriteLine(ages[0]);
            Console.WriteLine(agesRef[0]);
            //copying arrays
            int[] agesCopy = new int[ages.Length];
            ages.CopyTo(agesCopy, 0);

            agesCopy[0] = 100;
            Console.WriteLine(ages[0]);
            Console.WriteLine(agesCopy[0]);


            //2d Arrays
            int[,] numbers = new int[3,2];
            numbers[2,1] = 1;

            //Jagged arrays
            int[][] values = new int[3][];
            values[0] = new int[5];
            values[1] = new int[3];
            values[2] = new int[9];

            //---------------------------------------------------------------------------------------------
            //Collections
            //Generics - These are the good modern ones
            //list
            List<int> myLeastFavNums = new List<int>();
            myLeastFavNums.Add(11);
            foreach(int i in myLeastFavNums)
            {
                Console.WriteLine(i);
            }

            //Dictonaries
            Dictionary<string, bool> tasty = new Dictionary<string, bool>();
            tasty.Add("Pad Thai", true);
            tasty.Add("Mustard", false);
            //tasty.Remove("Mustard");
            
            Console.WriteLine(tasty["Pad Thai"]);
            foreach(KeyValuePair<string, bool> kvp in tasty)
            {
                if(kvp.Value == true)
                {
                    Console.WriteLine($"{kvp.Key} is tasty!");
                }
                else
                {
                    Console.WriteLine($"{kvp.Key} is not tasty");
                }
            }
            


            //Non-generics - These are the old wrinkly ones
            //ArrayList
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(5);
            //line below is allowed, but causes errors during runtime
            //myArrayList.Add("Justin");
            foreach(int i in myArrayList)
            {
                Console.WriteLine(i);
            }

            //Hashtable
            Hashtable phonebook = new Hashtable();
            phonebook.Add("Pizza Hut", 1234567890);
            phonebook.Add("Hungry Howies", 9999999999);
            //line below is allowed, but causes errors during runtime
            //phonebook.Add("Little Caesars", "987-654-3210");
            string pizzaShop = "Dominos";
            phonebook.Add(pizzaShop, 1231155612);
            //phonebook[pizzaShop]

            Console.WriteLine($"Pizza huts number is : {phonebook["Pizza Hut"]}");
            foreach(DictionaryEntry entry in phonebook)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }




            //School Dictionary example
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Mary", 5);
            students.Add("Tommy", 1);
            students.Add("a", 10);
            students.Add("b", 12);
            students.Add("c", 5);
            students.Add("d", 1);
            students.Add("e", 10);
            students.Add("bf", 12);
            students.Add("asdf", 8);
            students.Add("Jeff", 9);

            foreach(KeyValuePair<string, int> kvp in students)
            {
                Console.WriteLine($"{kvp.Key} is in {kvp.Value} grade");
            }

            

        }
    }
}
