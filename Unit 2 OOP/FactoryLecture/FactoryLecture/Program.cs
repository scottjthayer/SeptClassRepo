using System;

namespace FactoryLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sFactory = new ShapeFactory();

            Shape result = sFactory.GetShape("circle");

            result.Draw();
        }
    }
}
