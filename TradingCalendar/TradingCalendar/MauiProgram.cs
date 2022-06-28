namespace TradingCalendar;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Sitka.ttf", "Sitka");
				fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
			});

		return builder.Build();
	}
}
