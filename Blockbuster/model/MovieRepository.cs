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
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },


                 new Movie
                {
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },


                  new Movie
                {
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },


                   new Movie
                {
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },


                    new Movie
                {
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },


                     new Movie
                {
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },


                      new Movie
                {
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },


                       new Movie
                {
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },


                        new Movie
                {
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },

                         new Movie
                {
                   title = "",
                   director="",
                   studio  = "",
                   rating =""


                },
            };
        }
        public static List<Movie> GetAllMovies()
        {
            return _movies;
        }

        public static List<Movie> SearchByTitle(string title)
        {
            var matchingMovies = new List<Movie>();

            foreach (var movie in _movies)
            {
                if (movie.title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    matchingMovies.Add(movie);
                }
            }

            return matchingMovies;
        }
    }
}