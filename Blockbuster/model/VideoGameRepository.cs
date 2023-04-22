using System;

namespace Blockbuster
{
    public static class VideoGameRepository
    {
        private static List<VideoGame> _videoGames;
        static VideoGameRepository()
        {
            _videoGames = new List<VideoGame>
            {
                new VideoGame
                {
                    Title = "Call Of Duty",
                    Developer="Activision",
                    Rating= VideoGameRating.M

                },

                new VideoGame
                {
                    Title = "FIFA 23",
                    Developer="EA Sports",
                    Rating= VideoGameRating.E

                },

                new VideoGame
                {
                    Title = "WWE 2K23",
                    Developer="2K Sports",
                    Rating= VideoGameRating.T

                },

            };
        }

        public static void AddVideoGame(VideoGame videoGame)
        {
            _videoGames.Add(videoGame);
        }

        public static List<VideoGame> GetAllVideoGames()
        {
            return _videoGames;
        }

        public static void DeleteVideoGame(VideoGame videoGame)
        {
            _videoGames.Remove(videoGame);
        }

        public static List<VideoGame> SearchByTitle(string title)
        {
            var matchingVideoGames = new List<VideoGame>();

            foreach (var videoGame in _videoGames)
            {
                if (videoGame.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    matchingVideoGames.Add(videoGame);
                }
            }

            return matchingVideoGames;
        }
    }
}