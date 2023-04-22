namespace Blockbuster.views;

public partial class AddProductPage : ContentPage
{
	public AddProductPage()
	{
		InitializeComponent();
	}

    void ProductPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        var picker = (Picker)sender;
        var selectedItem = picker.SelectedItem?.ToString();

        if (selectedItem == "Movie")
        {
            MovieEntries.IsVisible = true;
            VideoGameEntries.IsVisible = false;

            MovieTitleEntry.Text = "";
            DirectorEntry.Text = "";
            StudioEntry.Text = "";
            MovieRatingPicker.SelectedIndex = -1;
        }

        else if (selectedItem == "Video Game")
        {
            MovieEntries.IsVisible = false;
            VideoGameEntries.IsVisible = true;

            VideoGameTitleEntry.Text = "";
            DeveloperEntry.Text = "";
            VideoGameRatingPicker.SelectedIndex = -1;
        }
        else
        {
            MovieEntries.IsVisible = false;
            VideoGameEntries.IsVisible = false;
        }

    }
    

    async void AddMovieButton_Clicked(System.Object sender, System.EventArgs e)
    {
        var movie = new Movie
        {
            Title = MovieTitleEntry.Text,
            Director = DirectorEntry.Text,
            Studio = StudioEntry.Text,
            Rating = (MovieRating)Enum.Parse(typeof(MovieRating), MovieRatingPicker.SelectedItem?.ToString())
        };

        MovieRepository.AddMovie(movie);

        await DisplayAlert("Success", "Movies was added", "OK");

        await Navigation.PopAsync();


    }

    async void AddVideoGameButton_Clicked(System.Object sender, System.EventArgs e)
    {
        var videoGame = new VideoGame
        {
            Title = VideoGameTitleEntry.Text,
            Developer = DeveloperEntry.Text,
            Rating = (VideoGameRating)Enum.Parse(typeof(VideoGameRating), VideoGameRatingPicker.SelectedItem?.ToString())
        };

        VideoGameRepository.AddVideoGame(videoGame);
        await DisplayAlert("Success", "Video Game was added", "OK");

        await Navigation.PopAsync();
    }
}