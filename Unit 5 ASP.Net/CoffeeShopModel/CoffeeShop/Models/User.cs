using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class User
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //No Constructors. Breaks code
        //public User(string first, string last, string email, string password)
        //{
        //    First = first;
        //    Last = last;
        //    Email = email;
        //    Password = password;
        //}
    }
}
