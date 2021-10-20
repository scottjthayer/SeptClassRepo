using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLecture
{
    class SavingsAccount : BankAccount
    {
        private double Balance;
        public override double balance { get { return Balance; } set { Balance = value; } }

        //constructor
        public SavingsAccount(double b)
        {
            Balance = b;
        }

        public override void deposit(double value)
        {
            Balance += value;
        }

        public override double withdraw(double value)
        {
            if (value > Balance)
            {
                return 0;
            }
            else
            {
                Balance -= value;
                return value;
            }
        }
    }
}
