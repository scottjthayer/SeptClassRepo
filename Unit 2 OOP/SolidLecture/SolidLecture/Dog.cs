using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLecture
{
    class Dog : Animal
    {

        public Dog(IBloodType blood) : base(blood)
        {

        }
        public override void Swim()
        {
            Console.WriteLine("The dog jumps off a diving board.");
            base.Swim();
        }
    }
}
