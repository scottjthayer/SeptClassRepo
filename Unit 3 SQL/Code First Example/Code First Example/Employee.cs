using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Code_First_Example
{
    class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        
    }
}
