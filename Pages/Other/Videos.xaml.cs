namespace Test.Pages.Other;

public partial class Videos : ContentPage
{
	public Videos()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        AnimatePage();
    }

    private async void AnimatePage()
    {
        await Task.Delay(100); // Delay for smoother transition (adjust as needed)
        await Content.TranslateTo(0, 0, 250, Easing.CubicOut); // Slide up animation
    }
}