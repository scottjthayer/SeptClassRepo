using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("Star Wars", "Scifi"),
                new Movie("Annihilation", "Scifi"),
                new Movie("The Nice Guys", "Comedy"),
                new Movie("Cloudy with a Chance of Meatballs", "Animation"),
                new Movie("Shrek", "Comedy"),
                new Movie("Toy Story", "Animation"),
                new Movie("The Blob", "Horror"),
                new Movie("Jurassic Park", "Scifi"),
                new Movie("The Lighthouse", "Drama"),
                new Movie("The Brave Little Toaster", "Scifi")
            };

            List<string> allGenres = movies.Select(M => M.Category).Distinct().ToList();
            

            //start of program
            Console.WriteLine("Welcome to the GC movie theater.");

            //Loop program
            bool runProgram = true;
            while (runProgram)
            {
                //user input
                //Console.WriteLine("Please enter a genre. Scifi/Comedy/Animation/Horror/Drama");
                Console.WriteLine("Please enter a genre:");
                for(int i = 0; i< allGenres.Count; i++)
                {
                    Console.WriteLine($"{i}. {allGenres[i]}");
                }
                string genre = "";

                //Validate Genre
                while (true)
                {
                    //genre = Console.ReadLine();
                    int id = (int)Validator.Validator.GetNumber(0, allGenres.Count-1);
                    genre = allGenres[id];
                    if(genre == "")
                    {
                        Console.WriteLine("That was blank, try again.");
                    }
                    else
                    {
                        break;
                    }
                }

                //Get all related genres
                List<Movie> result = GetMoviesGenre(genre, movies);

                //Display all movies
                foreach (Movie M in result)
                {
                    Console.WriteLine(M.Title);
                }

                //ask if they want to continue
                runProgram = Validator.Validator.getContinue("Would you like to keep looking at movies?");
            }
        }

        static List<Movie> GetMoviesGenre(string genre, List<Movie> movies)
        {
            return movies.Where(M => M.Category == genre).OrderBy(M => M.Title).ToList();
        }

    }
}
