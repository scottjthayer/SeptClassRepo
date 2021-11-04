using System;
using System.Collections.Generic;

#nullable disable

namespace CoffeeShop2
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FavDrink { get; set; }
        public DateTime Birthday { get; set; }
    }
}
