using System;
using System.Collections.Generic;

namespace Interface_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<iAnimal> zoo = new List<iAnimal>();
            Dog d = new Dog("Spot");
            RunCommands(d);
            zoo.Add(d);

            Giraffe g = new Giraffe("Smol boi");
            RunCommands(g);
            zoo.Add(g);
        }

        static void RunCommands(iAnimal a)
        {
            a.eat();
            a.move();
        }
    }
}
