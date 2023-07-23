using Microsoft.Maui.Graphics.Text;
using System.Security.Cryptography;
using Microsoft.Maui.Graphics;
using Test.Model;
using Test.Services;
using System.Collections.ObjectModel;
using Test.Pages.Other;
using Microsoft.Maui.Controls;
using System.Linq;

namespace Test
{
    public partial class MainPage : ContentPage
    {
        private DataService eventDataService;
        public ObservableCollection<Event> DisplayedItems { get; set; }
        public ObservableCollection<Event> Events { get; set; }
        public MainPage()
        {
            InitializeComponent();

            eventDataService = new DataService();
            DisplayedItems = eventDataService.GetDisplayedItems(6);
            Events = eventDataService.Events;

            BindingContext = this;
        }

        private void View_Event(object sender, TappedEventArgs e)
        {
            if (sender is Grid grid && grid.BindingContext is Event selectedEvent)
            {
                // Navigate to the EventDetailPage and pass the selectedEvent as a parameter
                Navigation.PushAsync(new Event_Info (selectedEvent));
            }
        }
        private void View_More(object sender, EventArgs e)
        {
            Navigation.PushAsync(new YourMotives());
        }
    }

}