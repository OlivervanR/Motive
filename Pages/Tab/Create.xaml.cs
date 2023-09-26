namespace Test;
using Test.Pages.Other;

public partial class Create : ContentPage
{
	public Create()
	{
		InitializeComponent();
	}

    private void AS_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Advanced_Settings());
    }
}