using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput = PigLatin.GetInput("Please input a word or sentence to translate to pig Latin");
            //split sentence into array
            string[] words = userInput.Split(" ");

            string result = "";
            //loop and send all into ToPigLatin
            foreach(string x in words)
            {
                result += PigLatin.ToPigLatin(x) + " ";
                
            }
            Console.WriteLine(result);
        }
    }
}
