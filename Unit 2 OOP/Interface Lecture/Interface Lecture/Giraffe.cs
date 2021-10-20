using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Lecture
{
    class Giraffe : iAnimal
    {
        private string Name;
        public string name { get { return Name; } set { Name = value; } }

        public Giraffe(string n)
        {
            Name = n;
        }

        public void eat()
        {
            Console.WriteLine($"{Name} eats some leafs on a very tall tree.");
        }

        public void move()
        {
            Console.WriteLine($"{Name} runs away.");
        }
    }
}
