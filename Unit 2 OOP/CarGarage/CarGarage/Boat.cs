using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    class Boat:Vehicle
    {
        //properties
        public bool Motorized;
        //Constructor
        public Boat(string name, double maxspeed, bool motorized) : base(name, maxspeed)
        {
            Motorized = motorized;
        }

        //Methods

        //overrides
        public override void drive()
        {
            Console.WriteLine($"You head to the water and get in the {Name}. You ride the boat at {MaxSpeed}. Does this boat use a motor? {Motorized}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Boat| Motorized: {Motorized}";
        }
    }
}
