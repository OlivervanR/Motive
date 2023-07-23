using System.Collections.ObjectModel;
using Test.Services;
using Test.Model;

namespace Test;

public partial class YourMotives : ContentPage
{
    private DataService eventDataService;
    public ObservableCollection<Event> Events { get; set; }
    public YourMotives()
    {
        InitializeComponent();

        eventDataService = new DataService();
        Events = eventDataService.Events;

        BindingContext = this;
    }

    private void View_Event(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new Discover());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
}
