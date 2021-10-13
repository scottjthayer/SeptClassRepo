using System;
using System.Collections.Generic;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Animal a = new Animal(100, "turtle");
            animals.Add(a);
            a.Eat();
            a.PrintDetails();
            Console.WriteLine(a.ToString());
            Console.WriteLine();

            Dog d = new Dog(15, "Baja Blast", "Green", "Corgi");
            animals.Add(d);
            d.Eat();
            d.fetch();
            d.PrintDetails();
            Console.WriteLine(d.ToString());

            Console.WriteLine();
            PrintInfo(a);
            PrintInfo(d);
            Console.WriteLine();

            //initializing a parent using a child
            Animal a2 = new Dog(15, "Felony", "Gray", "Grayhound");
            animals.Add(a2);

            foreach (Animal animal in animals)
            {
                //animal.PrintDetails();
                PrintInfo(animal);
            }

            /*even tho animals[1] was a dog, once it entered the list, it got converted into an animal.
             * 
             */
            //DogFetch(animals[1]);
        }


        static void PrintInfo(Animal animal)
        {
            animal.PrintDetails();
        }

        static void DogFetch(Dog dog)
        {
            dog.fetch();
        }
    }
}
