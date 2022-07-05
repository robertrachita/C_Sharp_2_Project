namespace TradingCalendar;
using CommunityToolkit.Mvvm.Input;
using TradingCalendar.ViewModel;
public partial class MainPage : ContentPage
{

    public MainPage(LoginPageViewModel vm)
	{

		InitializeComponent();
        BindingContext = vm;
    }

	private void Button_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(RegisterPage));
    }

    [ICommand]
    void Add()
    {
        
    }
}

