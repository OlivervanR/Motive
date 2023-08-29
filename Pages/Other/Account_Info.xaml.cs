namespace Test.Pages.Other;
using Test.Model;

public partial class Account_Info : ContentPage
{
	public Account_Info(Account selectedAccount)
	{
		InitializeComponent();
		BindingContext = selectedAccount;
	}
}