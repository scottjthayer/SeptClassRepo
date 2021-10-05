using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 6, 9, 1, 3, 0, 1 };
            //linq 
            int oddcount = numbers.Count(n => n % 2 == 1);
            Console.WriteLine($"There are {oddcount} odd numbers");
            //Old way
            int oddNum = 0;
            foreach(int i in numbers)
            {
                if (i%2 == 1)
                {
                    oddNum += 1;
                }
            }
            Console.WriteLine($"There are {oddNum} odd numbers");
            //Query Expression
            List<int> largest = (from n in numbers
                          where n == 9
                          select n).ToList();

            

            //Method
            List<int> above5 = numbers.Where(n => n > 5).ToList();
            Console.WriteLine("These are the numbers above 5");
            foreach(int num in above5)
            {
                Console.WriteLine(num);
            }


            //examples
            //first
            int FirstEven = numbers.First(n => n % 2 == 0);
            Console.WriteLine($"The first even number is {FirstEven}");

            //single
            int onlyNine = numbers.Single(n => n == 9);
            Console.WriteLine($"{onlyNine} only appears once");

            //any
            bool check = numbers.Any(n => n >= 10);
            Console.WriteLine($"Are there any numbers over ten? {check}");

            //where
            List<int> under5 = numbers.Where(n => n < 5).ToList();
            foreach(int num in under5)
            {
                Console.WriteLine(num);
            }

            //Display the frequency of the letter s in a given string
            string word = "Assessment";
            int sCount = word.Count(letter => letter == 's');
            Console.WriteLine($"The letter s appears in {word} {sCount} times");

            //Find the names in the list that start with J
            List<string> names = new List<string>
            {
                "Regen",
                "Wheeler",
                "Harlan",
                "Shawnee",
                "Sibley",
                "Demetris",
                "Sibyl",
                "Joelie",
                "Jili",
                "Geoffry"
            };

            List<string> jNames = names.Where(n => n.StartsWith("J")).ToList();
            foreach(string n in jNames)
            {
                Console.WriteLine(n);
            }

            //display an array of numbers in descending order
            int[] randomNumbers = { 6, 25, 9, 10, 9, 100, 1 };
            List<int> sortedArray = randomNumbers.OrderByDescending(n => n).ToList();
            foreach(int n in sortedArray)
            {
                Console.WriteLine(n);
            }

            //alt way
            int[] descNums = (from n in randomNumbers
                              orderby n descending
                              select n).ToArray();
            foreach (int n in descNums)
            {
                Console.WriteLine(n);
            }

            //calculate the average of all the odd numbers in an array using Linq
            //reusing randomNumbers
            List<int> OddNumbers = randomNumbers.Where(n => n % 2 == 1).ToList();
            double average = OddNumbers.Average();
            Console.WriteLine(average);
            
            //one line average
            double avg = randomNumbers.Where(n => n % 2 == 1).Average();

            //Find the sum of all the numbers that are greater than 10
            //reusing randomNumbers
            List<int> OverTen = randomNumbers.Where(n => n > 10).ToList();
            int overTenSum = OverTen.Sum();
            Console.WriteLine(overTenSum);

            //one line sum
            int sum = randomNumbers.Where(n => n > 10).Sum();
        }
    }
}
