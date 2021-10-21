using System;
using System.Collections.Generic;
using System.Text;

namespace MVCLecture
{
    class ItemView
    {
        public void DisplayItem(Item item)
        {
            Console.WriteLine($"{item.Name , -10} ${item.Price, -10}");
        }
    }
}
