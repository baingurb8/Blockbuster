using System;

namespace Blockbuster
{
    public static class MovieRepository
    {
        private static List<Movie> _movies;
        static MovieRepository()
        {
            _movies = new List<Movie>
            {
                new Movie
                {
                   Title = "Insidious",
                   Director="Dereck Glass",
                   Studio  = "WarneBros.",
                   Rating = MovieRating.PG13


                },


                 new Movie
                {
                   Title = "Harry Potter",
                   Director="Chris Colombus",
                   Studio  = "FOX",
                   Rating = MovieRating.PG


                },


                  new Movie
                {
                   Title = "Mario",
                   Director="Stephen Uzamaki",
                   Studio  = "Studio Perriot",
                   Rating = MovieRating.G


                },


                   new Movie
                {
                   Title = "John Wick",
                   Director="Chris Nolan",
                   Studio  = "Josh Films",
                   Rating = MovieRating.R


                },

            };
        }
        public static List<Movie> GetAllMovies()
        {
            return _movies;
        }



        public static void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public static void DeleteMovie(Movie movie)
        {
            _movies.Remove(movie);
        }
        public static List<Movie> SearchByTitle(string title)
        {
            var matchingMovies = new List<Movie>();

            foreach (var movie in _movies)
            {
                if (movie.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    matchingMovies.Add(movie);
                }
            }

            return matchingMovies;
        }
    }
}