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
                    title = "",
                    developer="",
                    rating=""

                },

            };
        }

        public static List<VideoGame> GetAllVideoGames()
        {
            return _videoGames;
        }

        public static List<VideoGame> SearchByTitle(string title)
        {
            var matchingVideoGames = new List<VideoGame>();

            foreach (var videoGame in _videoGames)
            {
                if (videoGame.title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    matchingVideoGames.Add(videoGame);
                }
            }

            return matchingVideoGames;
        }
    }
}