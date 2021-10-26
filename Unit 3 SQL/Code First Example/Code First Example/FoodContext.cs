using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code_First_Example
{
    class FoodContext : DbContext
    {
        public DbSet<FoodItem> foodItems { get; set; }
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FoodDB;Integrated Security=SSPI;");
        }
    }
}
