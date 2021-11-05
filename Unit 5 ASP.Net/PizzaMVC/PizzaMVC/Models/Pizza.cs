using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaMVC
{
    public partial class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Popularity { get; set; }
    }
}
