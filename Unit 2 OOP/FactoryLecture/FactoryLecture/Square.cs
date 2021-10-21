using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryLecture
{
    class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("You are looking at a square");
        }
    }
}
