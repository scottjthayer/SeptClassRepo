using System;
using System.Collections.Generic;
using System.Text;

namespace MVCLecture
{
    class ItemController
    {
        //properties
        public List<Item> inventory;
        //constructors
        public ItemController()
        {
            inventory = new List<Item>
            {
                new Item("Alcohol", 2.50),
                new Item("Whiskey", 15),
                new Item("Vodka", 7)
            };
        }
        //methods

        public void DisplayItems()
        {
            ItemView view = new ItemView();
            foreach(Item i in inventory)
            {
                view.DisplayItem(i);
            }
        }
    }
}
