namespace TradingCalendar;
using CommunityToolkit.Mvvm.Input;
using TradingCalendar;
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    public async void goToRegister()
	{
		await Shell.Current.GoToAsync(nameof(RegisterPage));
	}
}

