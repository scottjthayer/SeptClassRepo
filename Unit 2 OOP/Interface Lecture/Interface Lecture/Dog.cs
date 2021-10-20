using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Lecture
{
    class Dog : iAnimal
    {
        private string Name;
        public string name { get { return Name; } set { Name = value; } }

        public Dog(string n)
        {
            Name = n;
        }

        public void eat()
        {
            Console.WriteLine($"{Name} eats kibble.");
        }

        public void move()
        {
            Console.WriteLine($"{Name} runs in circles.");
        }
    }
}
