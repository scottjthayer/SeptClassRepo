using System;

namespace AbstractLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount s = new SavingsAccount(5);
            s.deposit(7);

            Console.WriteLine(s.balance);

            double cash = s.withdraw(11);
            Console.WriteLine($"I am holding {cash} and my savings has {s.balance}");

            CheckingsAccount c = new CheckingsAccount(8);

            CheckBalance(s);
            CheckBalance(c);
            
        }

        static void CheckBalance(BankAccount b)
        {
            Console.WriteLine(b.balance);
        }
    }
}
