using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLecture
{
    class PetOwner
    {
        //Moved from animal to allow single responsiblity
        public void PetFur()
        {
            Console.WriteLine("Pet fur");
        }
    }
}
