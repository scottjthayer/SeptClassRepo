using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLecture
{
    abstract class BankAccount
    {
        public abstract double balance { get; set; }
        public abstract void deposit(double value);
        public abstract double withdraw(double value);
    }
}
