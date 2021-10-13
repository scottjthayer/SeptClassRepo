using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    class ATV:Vehicle
    {
        //properties
        public bool OffRoad;
        //constructor
        public ATV(string name, double maxspeed, bool offroad) :base(name, maxspeed)
        {
            OffRoad = offroad;
        }
        //methods

        //overrides
        public override void drive()
        {
            Console.WriteLine($"You hope on the {Name} and ride it away at {MaxSpeed}. Do you go off road? {OffRoad}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} ATV | Offroad: {OffRoad}";
        }

    }
}
