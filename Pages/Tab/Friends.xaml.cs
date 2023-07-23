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
}