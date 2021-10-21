using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    class PigLatin
    {
        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //compared 1 char to a string of vowels
            return vowels.Contains(c);
        }

        public static bool IsSpecialCharacter(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        //found special character
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return true;
                    }
                }
            }
            //no special characters
            return false;
        }

        public static bool NoVowels(string word)
        {
            bool noVowels = true;
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }

            return noVowels;
        }

        public static string ConvertWordVowel(string word)
        {
            //added w
            return word + "way";
        }

        public static string ConvertWordConsonant(string word)
        {
            int vowelIndex = -1;
            //Handle going through all the consonants
            for (int i = 0; i <= word.Length; i++)
            {
                if (IsVowel(word[i]) == true)
                {
                    vowelIndex = i;
                    break;
                }
            }

            string sub = word.Substring(vowelIndex);
            string postFix = word.Substring(0, vowelIndex);

            return sub + postFix + "ay";
        }

        public static string ToPigLatin(string word)
        {

            if (IsSpecialCharacter(word))
            {
                return word;
            }

            if (NoVowels(word))
            {
                return word;
            }

            char firstLetter = word[0];
            string output = "placeholder";
            if (IsVowel(firstLetter) == true)
            {
                output = ConvertWordVowel(word);
            }
            else
            {
                output = ConvertWordConsonant(word);
            }

            return output;
        }
    }
}
