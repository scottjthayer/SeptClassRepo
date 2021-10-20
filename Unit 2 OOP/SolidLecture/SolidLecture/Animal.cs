using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLecture
{
    class Animal
    {
        //dependency
        private ISwimming swim = new Swimming();

        private IBloodType blood;

        public Animal(IBloodType bloodType)
        {
            blood = bloodType;
        }

        public void GetBloodType()
        {
            blood.BloodType();
        }

        public void Eat()
        {
            Console.WriteLine("Eats");
        }
        public void Run()
        {
            //Open closed princible
            //we shouldn't modify existing functions to prevent bugs
            //if (isInWater)
            //{
            //    Console.WriteLine("Swimming");
            //}
            //else
            //{
            Console.WriteLine("Runs");
            //}
            
        }
        public virtual void Swim()
        {
            swim.swimming();
        }
        

        //Single responsiblity.
        //Moved to a PetOwner.cs . Animal doesn't need this

        //public void PetFur()
        //{
        //    Console.WriteLine("Pet fur");
        //}
    }
}
