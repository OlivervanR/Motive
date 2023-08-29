using Microsoft.Maui.Graphics.Text;
using System.Security.Cryptography;
using Microsoft.Maui.Graphics;
using Test.Model;
using Test.Services;
using System.Collections.ObjectModel;
using Test.Pages.Other;
using Microsoft.Maui.Controls;
using System.Linq;

namespace Test;


public partial class Friends : ContentPage
{
    private DataService friendDataService;
    public ObservableCollection<Account> Account { get; set; }
    public Friends()
    {
        InitializeComponent();

        friendDataService = new DataService();
        Account = friendDataService.Accounts;

        BindingContext = this;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(e.NewTextValue))
            friendresults.ItemsSource = Account;
        else
            friendresults.ItemsSource = Account.Where(i => i.Name.ToLower().Contains(e.NewTextValue.ToLower()));
    }

    private void View_Profile(object sender, TappedEventArgs e)
    {
        if (sender is Grid grid && grid.BindingContext is Account selectedAccount)
        {
            // Navigate to the EventDetailPage and pass the selectedEvent as a parameter
            Navigation.PushAsync(new Account_Info(selectedAccount));
        }
    }
}