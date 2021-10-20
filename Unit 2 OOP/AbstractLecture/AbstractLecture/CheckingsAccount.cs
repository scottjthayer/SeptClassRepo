using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLecture
{
    class CheckingsAccount : BankAccount
    {
        private double Balance;
        public override double balance { get { return Balance; } set { Balance = value; } }

        public CheckingsAccount(double b)
        {
            Balance = b;
        }

        public override void deposit(double value)
        {
            Balance += value;
        }

        public override double withdraw(double value)
        {
            Balance -= value;
            return value;
        }
    }
}
