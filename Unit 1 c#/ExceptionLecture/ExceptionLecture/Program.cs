using System;
using System.Text.RegularExpressions;

namespace ExceptionLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //COMMON CODE ISSUES

            //Runtime errors
            //replace 1 with name to get formatexpection
            int value = int.Parse("1");

            //replace 0 with 100 to get IndexOutOfRangeException
            int[] nums = new int[5];
            Console.WriteLine(nums[0]);


            //SYNTAX ERRORS
            //unblock comment this. leave normal comment
            /*
            while (true)
            {


            //}
            */

            //change to sting to get error
            string name = "Justin";


            //EXECEPTION HANDLING
            double total = 0;
            try
            {
                Console.WriteLine("Please enter a total. Needs to be higher than 0");
                total = double.Parse(Console.ReadLine());
                if(total <= 0)
                {
                    //Console.WriteLine("Needs to be greater than 0");
                    throw new Exception("Needs to be greater than 0");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("That was not a number");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine("Something went wrong");
            }

            //tryparse
            int birthyear = 12222;

            Console.WriteLine("Please enter your birth year");
            string result = Console.ReadLine();

            bool isInt = int.TryParse(result, out birthyear);

            if(isInt == true)
            {
                Console.WriteLine($"You are born in {birthyear}");
            }
            else
            {
                Console.WriteLine("That was not an int");
                Console.WriteLine(birthyear);
            }

            //REGEX
            Console.WriteLine("Please enter a phone number with area code.");
            string phoneNum = Console.ReadLine();
            if(Regex.IsMatch(phoneNum, @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$"))
            {
                Console.WriteLine("That was a phone number.");
            }
            else
            {
                Console.WriteLine("That was not a phone number");
            }


            //software testing Demo
            int num1 = 0;
            int num2 = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a number.");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter a second number");
                    num2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a valid input");
                }
            }

            int num3 = num1 + num2;
            Console.WriteLine($"The numbers added together equals {num3}");


            //exercise
            //get user input. try catch it. Make sure its between 0-100 and that its a real number. Display it to the user once its a number
            int getnumber = 0;
            while(true)
            {
                try
                {
                Console.WriteLine("Please enter a number between 0-100");
                getnumber = int.Parse(Console.ReadLine());
                if (getnumber >100)
                {
                    throw new Exception("That number is too large.");
                }
                else if (getnumber <0)
                {
                    throw new Exception("That number is too small.");
                }
                else
                {
                    //right range
                    break;
                   }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a valid number");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"Your number is {getnumber}");

            //get a bank account from the user as a string. Use a TryParse on it to turn it into a number.

            Console.WriteLine("Please tell me how much money you have in your bank account");
            string bank = Console.ReadLine();

            double bankAmount = 0;

            bool isBank = double.TryParse(bank, out bankAmount);

            if(isBank == true)
            {
                Console.WriteLine($"Your bank has {bankAmount}");
            }
            else
            {
                Console.WriteLine("That was not valid.");
            }

            //get email from a user. Use regex to confirm its an email

            Console.WriteLine("Please type your email.");
            string email = Console.ReadLine();
            
            if(Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                Console.WriteLine($"{email} is an email");
            }
            else
            {
                Console.WriteLine("That was not an email");
            }
        }
    }
}
