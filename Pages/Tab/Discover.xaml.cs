namespace Test;

public partial class Discover : ContentPage
{
	private double initialY;
	private double translationY;
	public Discover()
	{
		InitializeComponent();

        // Register the gesture recognizer for sliding
        var gestureRecognizer = new PanGestureRecognizer();
        gestureRecognizer.PanUpdated += OnPanUpdated;
        slidingPanel.GestureRecognizers.Add(gestureRecognizer);
    }

    private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)
        {
            case GestureStatus.Started:
                // Store the initial Y position of the sliding panel
                initialY = slidingPanel.TranslationY;
                break;

            case GestureStatus.Running:
                // Calculate the translation distance based on the pan gesture
                translationY = initialY + e.TotalY;

                // Ensure the sliding panel stays within the visible area
                var maxY = Application.Current.MainPage.Height - slidingPanel.Height;
                var minY = 0; // Minimum Y position

                translationY = Math.Clamp(translationY, minY, maxY);

                // Apply the translation to the sliding panel
                slidingPanel.TranslationY = translationY;
                break;

            case GestureStatus.Completed:
            case GestureStatus.Canceled:
                // Determine whether to slide the panel up or down based on the final translation
                if (translationY > Application.Current.MainPage.Height * 0.5)
                {
                    // Slide the panel to the bottom of the screen
                    slidingPanel.TranslateTo(0, Application.Current.MainPage.Height);
                }
                else
                {
                    // Slide the panel back to the top of the screen
                    slidingPanel.TranslateTo(0, 0);
                }
                break;
        }
    }
}