using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Movie
    {
        private string Title { get; set; }
        private string Category { get; set; }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public static void GetHorror(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie.Category.Equals("Horror", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }

        public static void GetSciFi(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie.Category.Equals("SciFi", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }

        public static void GetAnimated(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie.Category.Equals("Animated", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }

        public static void GetDrama(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie.Category.Equals("Drama", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }
    }

}
