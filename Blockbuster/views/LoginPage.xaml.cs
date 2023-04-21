namespace Blockbuster;
using Blockbuster.model;
using Blockbuster.views;

public partial class LoginPage : ContentPage
{
    private string _userType = "Customer";

	public LoginPage()
	{
		InitializeComponent();
	}

    void LoginButton_Clicked(System.Object sender, System.EventArgs e)
    {
        if(string.IsNullOrEmpty(UserNameEntry.Text) || (string.IsNullOrEmpty(PassWordEntry.Text))){

            DisplayAlert("Error", "Make ksure username and password are valid", "Ok");
        }

        else if (_userType == "Admin")
        {

            Navigation.PushAsync(new ShopPage(true));

        }
        else
        {
            Navigation.PushAsync(new ShopPage(false));

        }
    }


    void RadioButton_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        RadioButton radioButton = (RadioButton)sender;
        if (radioButton.IsChecked)
        {
            _userType = radioButton.Content.ToString();
        }
    }

}
