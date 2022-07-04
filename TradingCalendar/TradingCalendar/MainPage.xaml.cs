namespace TradingCalendar;

using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using TradingCalendar;
public partial class MainPage : ContentPage
{

        public MainPage()
	{

			InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(RegisterPage));
    }
}

public class Database : DbContext
{
    private const string conn = $"Server=oliadkuxrl9xdugh.chr7pe7iynqr.eu-west-1.rds.amazonaws.com; Database=rnjhdkckwifts8kj; User Id=f5ytxsgeiwojfsy7; Password=q20j9i15pgyyoi3x";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(conn);
    }
}

