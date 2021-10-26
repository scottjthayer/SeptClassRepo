using System;
using System.Linq;

namespace Code_First_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //add using statement when using a DB
            using(FoodContext context = new FoodContext())
            {
                //No need to create ID. it will auto increment
                FoodItem item = new FoodItem();
                item.Name = "Fries";
                item.Price = 2.00;

                context.foodItems.Add(item);

                //ALWAYS SAVE WHEN DONE
                context.SaveChanges();

                foreach(FoodItem i in context.foodItems)
                {
                    Console.WriteLine(i.Name);
                }

            }
            Console.WriteLine($"Database has been updated.");
        }
    }
}
