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

public partial class Groups : ContentPage
{
	private DataService groupDataService;
    public ObservableCollection<Group> Group { get; set; }
    public Groups()
	{
		InitializeComponent();

        groupDataService = new DataService();
        Group = groupDataService.Groups;

        BindingContext = this;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(e.NewTextValue))
            groupresults.ItemsSource = Group;
        else
            groupresults.ItemsSource = Group.Where(i => i.Name.ToLower().Contains(e.NewTextValue.ToLower()));
    }
}