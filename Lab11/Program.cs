using System;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Coco", "Animated"));
            movies.Add(new Movie("Southpaw", "Drama"));
            movies.Add(new Movie("Poltergeist", "Horror"));
            movies.Add(new Movie("Arrival", "SciFi"));
            movies.Add(new Movie("Zootopia", "Animated"));
            movies.Add(new Movie("Loft", "Drama"));
            movies.Add(new Movie("Carrie", "Horror"));
            movies.Add(new Movie("Avatar", "SciFi"));
            movies.Add(new Movie("Inception", "SciFi"));
            movies.Add(new Movie("Alladin", "Animated"));


            Console.WriteLine("Welcome to the Movie List Application");

            char continueLoop;

               do
               {
                    Console.WriteLine("What movie type are you interested in?");
                    Console.Write("You're options are Animated, Drama, SciFi and Horror ");
                    var userInput = Console.ReadLine();

                    if (userInput.Equals("Horror", StringComparison.OrdinalIgnoreCase))
                    {
                        Movie.GetHorror(movies);
                    }
                    else if (userInput.Equals("Animated", StringComparison.OrdinalIgnoreCase))
                    {
                        Movie.GetAnimated(movies);
                    }
                    else if (userInput.Equals("SciFi", StringComparison.OrdinalIgnoreCase))
                    {
                        Movie.GetSciFi(movies);
                    }
                    else if (userInput.Equals("Drama", StringComparison.OrdinalIgnoreCase))
                    {
                        Movie.GetDrama(movies);
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid choice.");
                    }

                    Console.Write("Would you like to continue (y/n)? ");
                    continueLoop = char.Parse(Console.ReadLine().ToUpper());
                        


               } while (continueLoop.Equals(char.Parse("Y")));
            
            
            Console.WriteLine("Have a Great Day!!");
            Console.ReadKey();
            
        }
    }
}
