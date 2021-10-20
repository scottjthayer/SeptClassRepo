using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLecture
{
    class WarmBlooded : IBloodType
    {
        public void BloodType()
        {
            Console.WriteLine("This animal is warm blooded");
        }
    }
}
