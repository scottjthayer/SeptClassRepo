using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLecture
{
    class Hippo: Animal
    {
        public Hippo(IBloodType blood) : base(blood)
        {

        }
        public override void Swim()
        {
            Console.WriteLine("This animal cannot swim. They run through the water.");
        }
    }
}
