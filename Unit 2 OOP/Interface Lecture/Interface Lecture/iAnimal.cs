using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Lecture
{
    interface iAnimal
    {
        string name { get; set; }

        void eat();
        void move();
    }
}
