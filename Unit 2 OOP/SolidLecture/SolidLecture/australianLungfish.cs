using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLecture
{
    class australianLungfish : Animal
    {
        private IAquatic aquatic = new Aquatic();

        public australianLungfish(IBloodType blood) : base(blood)
        {

        }

        public override void Swim()
        {
            base.Swim();
            aquatic.breathUnderwater();
        }
    }
}
