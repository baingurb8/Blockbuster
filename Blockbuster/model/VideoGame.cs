using System;
namespace Blockbuster
{
    public enum VideoGameRating
    {
        E,
        T,
        M
    }

    public class VideoGame
	{
		public string Title { get; set; }
        public VideoGameRating Rating { get; set; }
        public string Developer { get; set; }
    }
}

