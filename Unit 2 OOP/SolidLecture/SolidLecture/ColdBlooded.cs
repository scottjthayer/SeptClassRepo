using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLecture
{
    class ColdBlooded : IBloodType
    {
        public void BloodType()
        {
            Console.WriteLine("This animal is cold blooded");
        }
    }
}
