using System;

namespace Console_Fonts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            ConsoleHelper.SetCurrentFont("MS Gothic", 100);
            Console.WriteLine("Hewwo wowld");
        }
    }
}
