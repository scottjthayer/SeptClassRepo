using System;

namespace SolidLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog(new ColdBlooded());
            d.GetBloodType();
        }
    }
}
