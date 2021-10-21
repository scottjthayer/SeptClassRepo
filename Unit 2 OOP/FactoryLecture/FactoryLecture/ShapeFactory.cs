using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryLecture
{
    class ShapeFactory
    {
        public Shape GetShape(string choice)
        {
            if (choice == "circle")
            {
                return new Circle();
            }
            else if (choice == "square")
            {
                return new Square();
            }
            else if (choice == "triangle")
            {
                return new Triangle();
            }

            return null;
        }
    }
}
