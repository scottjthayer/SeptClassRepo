using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture
{
    class Dog : Animal
    {
        //properties
        public string Color;
        public bool IsGoodDog;
        public string Breed;

        //constructor
        public Dog(int maxAge, string name, string color, string breed):base(maxAge, name)
        {
            Color = color;
            Breed = breed;
            IsGoodDog = true;
        }

        //methods
        public void fetch()
        {
            Console.WriteLine($"{Name} runs and fetches a very large stick. It is twice his size.");
        }
        public void bark()
        {
            Console.WriteLine($"{Name} barks after a bird.");
        }
        //overridden method
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"This dog has {Color} fur, is a {Breed} and is it a good dog? {IsGoodDog}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Dog: Color: {Color} Breed type: {Breed} Good Dog: {IsGoodDog}";
        }
    }
}
