
namespace Blockbuster.views;

public partial class ShopPage : ContentPage
{
	public ShopPage(bool isAdmin)
	{
		InitializeComponent();

        AddButton.IsVisible = isAdmin;

       
    }


    //void MoviesSearchButton_Clicked(System.Object sender, System.EventArgs e)
    //{
    //   MoviesListView.ItemsSource = MovieRepository.SearchByTitle(MovieSearchEntry.Text);
    //}
    //void VideoGamesSearchButton_Clicked(System.Object sender, System.EventArgs e)
    //{
    //    VideoGamesListView.ItemsSource = VideoGameRepository.SearchByTitle(VideoGameSearchEntry.Text);
    //}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        int movieTotal = MovieRepository.GetAllMovies().Count();
        int videoGameTotal = VideoGameRepository.GetAllVideoGames().Count();
        MoviesAvalaibleText.Text = $"Movies Available: {movieTotal}";
        VideoGameAvalaibleText.Text = $"Video Games Available: {videoGameTotal}";
        MoviesListView.ItemsSource = null;
        VideoGamesListView.ItemsSource = null;
        MoviesListView.ItemsSource = MovieRepository.GetAllMovies();
        VideoGamesListView.ItemsSource = VideoGameRepository.GetAllVideoGames();


    }
    void AddButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new AddProductPage());
    }

    async void VideoGamesListView_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        VideoGame videoGame = (VideoGame)e.Item;

        bool rented = await DisplayAlert(videoGame.Title, $"Developer: {videoGame.Developer}\n\nRating: {videoGame.Rating}", "Rent", "Cancel");
        if (rented)
        {
            VideoGameRepository.DeleteVideoGame(videoGame);
            OnAppearing();
        }
        OnAppearing();
    }
    async void MoviesListView_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        Movie movie = (Movie)e.Item;

        bool rented = await DisplayAlert(movie.Title, $"Director: {movie.Director}\nStudio: {movie.Studio}\nRating: {movie.Rating}", "Rent", "Cancel");

        if (rented)
        {
            MovieRepository.DeleteMovie(movie);
            OnAppearing();

        }
        OnAppearing();

    }

    void RadioButton_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        if (e.Value && sender == MovieButton)
        {
            MovieSearchEntry.IsVisible = true;
            MoviesListView.IsVisible = true;
            MoviesAvalaibleText.IsVisible = true;
            VideoGamesListView.IsVisible = false;
            VideoGameAvalaibleText.IsVisible = false;
            VideoGameSearchEntry.IsVisible = false;
        }
        else if (e.Value && sender == VideoGameButton)
        {
            MovieSearchEntry.IsVisible = false;
            MoviesListView.IsVisible = false;
            MoviesAvalaibleText.IsVisible = false;
            VideoGameAvalaibleText.IsVisible = true;
            VideoGamesListView.IsVisible = true;
            VideoGameSearchEntry.IsVisible = true;
        }
    }
}