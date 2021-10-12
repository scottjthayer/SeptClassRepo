using System;

namespace OOPShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop myShop = new Shop();

            myShop.DisplayShop();
            Console.WriteLine("Please choose an item to buy");
            string choice = Console.ReadLine();
            Item result = myShop.purchaseItem(choice);

            Console.WriteLine($"You purchased a {result.name} for ${result.value}");
        }
    }
}
