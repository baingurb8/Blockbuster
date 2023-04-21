using Blockbuster.model;
namespace Blockbuster.views;

public partial class ShopPage : ContentPage
{
	public ShopPage(bool isAdmin)
	{
		InitializeComponent();

        AddButton.IsVisible = isAdmin;

        // Populate the "Movies" tab with movies from the repository
        MoviesListView.ItemsSource = MovieRepository.GetAllMovies();

        // Populate the "Video Games" tab with video games from the repository
        VideoGamesListView.ItemsSource = VideoGameRepository.GetAllVideoGames();
    }

    // Handle the "Search" button click event for the "Movies" tab
    //void MoviesSearchButton_Clicked(System.Object sender, System.EventArgs e)
    //{
    //    MoviesListView.ItemsSource = MovieRepository.SearchByTitle(SearchEntry.Text);
    //}

    //// Handle the "Search" button click event for the "Video Games" tab
    //void VideoGamesSearchButton_Clicked(System.Object sender, System.EventArgs e)
    //{
    //    VideoGamesListView.ItemsSource = VideoGameRepository.SearchByTitle(SearchEntry.Text);
    //}

    void AddButton_Clicked(System.Object sender, System.EventArgs e)
    {
    }

    void VideoGamesListView_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
    }

    void MoviesListView_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
    }
}