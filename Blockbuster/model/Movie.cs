using System;
namespace Blockbuster
{
	public enum MovieRating
	{
		G,
		PG,
		PG13,
		R,
	}
    public class Movie
	{
		public string Title { get; set; }
		public string Director { get; set; }
		public string Studio { get; set; }
		public MovieRating Rating { get; set; }
		
	}
}

