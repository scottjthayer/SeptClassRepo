using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    class Vehicle
    {
        //properties
        public string Name;
        public double MaxSpeed;
        //Constructor
        public Vehicle(string name, double maxspeed)
        {
            Name = name;
            MaxSpeed = maxspeed;
        }
        //method
        public virtual void drive()
        {
            Console.WriteLine($"You drive the {Name} at {MaxSpeed} mph");
        }
        //overrides
        public override string ToString()
        {
            return $"Vehicle | Name: {Name} Maxspeed: {MaxSpeed}";
        }
    }
}
