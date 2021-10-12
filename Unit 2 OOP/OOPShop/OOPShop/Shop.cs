using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPShop
{
    class Shop
    {
        //properties
        private List<Item> inventory = new List<Item>
        {
            new Item("Chips", 1.99),
            new Item("Pop", 2.50),
            new Item("Candy", 1.00)
        };
        //constructor
        /*
        public Shop()
        {

        }
        */
        //methods
        public void DisplayShop()
        {
            foreach(Item i in inventory)
            {
                Console.WriteLine($"{i.name} {i.value}");
            }
        }

        public Item purchaseItem(string name)
        {
            return inventory.Find(i => i.name == name);

            /*
            Item result = null;
            foreach(Item i in inventory)
            {
                if(i.name == name)
                {
                    result = i;
                }
            }
            return result;
            */
        }
    }
}
