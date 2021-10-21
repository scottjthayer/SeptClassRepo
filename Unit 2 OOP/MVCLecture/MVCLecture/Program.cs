using System;

namespace MVCLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemController controller = new ItemController();
            controller.DisplayItems();
        }
    }
}
