using System;
using System.Collections.Generic;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> Garage = new List<Vehicle>
            {
                new ATV("Raptor", 100, true),
                new Boat("Yacht", 75, true),
                new Car("Ferrari", 220, 4, 2),
                new Car("Mustang", 200, 4, 2),
                new Boat("Jet Ski", 100, true),
                new ATV("X-PRO", 90, true),
                new Car("Ferrari", 220, 4, 2),
                new Car("Mustang", 200, 4, 2),
                new ATV("Raptor", 100, true),
                new Boat("Yacht", 75, true)
            };

            foreach(Vehicle vehicle in Garage)
            {
                vehicle.drive();
            }
            
        }
    }
}
