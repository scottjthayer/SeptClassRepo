using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture
{
    class Animal
    {
        //properties
        public int MaxAge;
        public string Name;
        //constructor
        public Animal(int maxage, string name)
        {
            MaxAge = maxage;
            Name = name;
        }
        //methods
        public void Eat()
        {
            Console.WriteLine($"{Name} has eaten");
        }
        //virtual allows you to override
        public virtual void PrintDetails()
        {
            Console.WriteLine($"This animal's name is {Name} and lives until {MaxAge}");
        }

        public override string ToString()
        {
            return $"Animal: Name:{Name} MaxAge: {MaxAge}";
        }
    }
}
