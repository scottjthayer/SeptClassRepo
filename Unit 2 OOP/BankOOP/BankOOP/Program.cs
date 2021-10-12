using System;

namespace BankOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank(100);
            double x = myBank.money;
            //.money only has a getter, can't set
            //myBank.money = x;

            Console.WriteLine(myBank.money);
            myBank.Deposit(35);
            Console.WriteLine(myBank.money);
            double cash = myBank.Withdraw(20);
            Console.WriteLine($"I am holding {cash} after withdrawl.");
            Console.WriteLine(myBank.money);
        }
    }
}
