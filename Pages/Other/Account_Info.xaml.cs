namespace Test.Pages.Other;
using Test.Model;

public partial class Account_Info : ContentPage
{
	public Account_Info(Account selectedAccount)
	{
		InitializeComponent();
		BindingContext = selectedAccount;
	}

    private bool isButtonClicked = false;
    private void Button_Clicked(object sender, EventArgs e)
    {     
        if (isButtonClicked)
        {
            Favorites.Text = "Prefered Venue";
            Favorites.BackgroundColor = Color.FromArgb("#032752");
            Favorites.FontFamily = "Akira";
        }
        
        else
        {
            Favorites.Text = "Club";
            Favorites.BackgroundColor = Color.FromArgb("#1E1E1E");
            Favorites.FontFamily = "Garet";
        }
        
        isButtonClicked = !isButtonClicked;
        SemanticScreenReader.Announce(Favorites.Text);
    }
}