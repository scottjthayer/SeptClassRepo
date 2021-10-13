using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    class Car: Vehicle
    {
        //properties
        public int Wheels;
        public int Seats;
        //constructor
        public Car(string name, double maxspeed, int wheels, int seats) : base(name, maxspeed)
        {
            Wheels = wheels;
            Seats = seats;
        }
        
        //methods

        //overrides
        public override void drive()
        {
            Console.WriteLine($"You hop in the 1 out of {Seats} seats in your {Name} and drive at {MaxSpeed}. You drift with your {Wheels} wheels.");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Car| Wheels: {Wheels} Seats: {Seats}";
        }
    }
}
