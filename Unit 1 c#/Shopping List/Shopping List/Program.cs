using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> shop = new Dictionary<string, double>
            {
                {"Gum", 0.99 },
                {"Pringles", 1.99 },
                {"Gas", 3.50 },
                {"Chocolate cover honeybuns", 1.00 },
                {"Monster", 2.50 },
                {"Soda", 1.50 },
                {"Red Bull", 3.39 },
                {"Baja Blast", 1.89 },
                {"Protein Bar", 3.00 },
                {"Tall Boy", 2.50 },
                {"Chex Mix", 3.20 },
                {"Hot Cheeto Puffcorn", 2.00 },
                {"Reeses", 3.50 }
            };

            List<string> itemNames = new List<string>();
            List<double> itemPrices = new List<double>();
            List<int> itemQuantities = new List<int>();

            bool runProgram = true;

            while (runProgram)
            {
                //Shop display
                DisplayShop(shop);
                string result = GetItem(shop);
                //Ask for quanity
                int quanity = GetAmount();

                //display item
                Console.WriteLine($"You purchased {quanity} {result} for ${shop[result]:0.00}");

                //storing items in cart
                itemNames.Add(result);
                itemPrices.Add(shop[result]);
                itemQuantities.Add(quanity);

                //ask if continue
                runProgram = GetContinue();
            }
            //display receipt
            DisplayReceipt(itemNames, itemPrices, itemQuantities);
        }

        static int GetAmount()
        {
            int result = 0;
            while(true)
            {
                Console.WriteLine("How many would you like to buy?");
                result = int.Parse(Console.ReadLine());
                //0 or lower
                if(result <= 0)
                {
                    Console.WriteLine("You cannot purchase 0 or a negative amount.");
                }
                //1 or higher
                else
                {
                    break;
                }
            }
            return result;
        }

        static void DisplayReceipt(List<string> itemNames, List<double> itemPrices, List<int> itemQuantities)
        {
            Console.WriteLine("This is your receipt");
            Console.WriteLine();
            Console.WriteLine(string.Format($"{"Item",-25}{"Price",-25}{"Quantity", -25}"));
            Console.WriteLine();
            for (int i = 0; i<itemNames.Count; i++)
            {
                Console.WriteLine(string.Format($"{itemNames[i],-25}{itemPrices[i].ToString("0.00"),-25}{itemQuantities[i],-25}"));
            }
            //Average price
            Console.WriteLine($"Average price of items: {Math.Round(itemPrices.Average(), 2)}");
        }

        static bool GetContinue()
        {
            bool result = true;
            while(true)
            {
                Console.WriteLine("Would you like to continue shopping? y/n");
                string choice = Console.ReadLine();
                if(choice == "y")
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
                    Console.WriteLine("That was not a valid choice");
                }
            }
            return result;
        }

        static string GetItem(Dictionary<string, double> shop)
        {
            string result = "";
            while(true)
            {
                Console.WriteLine("Please type the name of the item you wish to purchase.");
                result = Console.ReadLine();
                //Returns true if key exists
                if(shop.ContainsKey(result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That was not in the shop. Try again.");
                }
            }
            return result;
        }

        static void DisplayShop(Dictionary<string, double> shop)
        {
            //Shop display
            Console.WriteLine(string.Format($"{"Item",-25}{"Price",-25}"));
            Console.WriteLine();
            foreach (KeyValuePair<string, double> kvp in shop)
            {
                Console.WriteLine(string.Format($"{kvp.Key,-25}{kvp.Value.ToString("0.00"),-25}"));
            }
        }

    }
}
