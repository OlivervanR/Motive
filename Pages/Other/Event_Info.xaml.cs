using System.ComponentModel;
using Test.Model;

namespace Test
{
    public partial class Event_Info : ContentPage
    {
        private bool isButtonClicked = false;
        public Event_Info(Event selectedEvent)
        {
            InitializeComponent();
            BindingContext = selectedEvent;
        }

        public bool IsButtonClicked
        {
            get => isButtonClicked;
            set
            {
                if (isButtonClicked != value)
                {
                    isButtonClicked = value;
                    OnPropertyChanged(nameof(IsButtonClicked));
                }
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            IsButtonClicked = !IsButtonClicked;
        }
    }
}