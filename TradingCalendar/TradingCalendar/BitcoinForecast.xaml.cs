namespace TradingCalendar;

public partial class BitcoinForecast : ContentPage
{
	public BitcoinForecast()
	{
		InitializeComponent();
        
        var sampleData = new MLModel1.ModelInput()
        {
            SNo = 1F,
            Name = @"Bitcoin",
            Symbol = @"BTC",
            Date = @"2013-04-29 23:59:59",
            High = 1.47488E+16F,
            Low = 1340F,
            Open = 1.34444E+16F,
            Volume = 0F,
            Marketcap = 1.603769E+10F,
        };

        //Load model and predict output
        var result = MLModel1.Predict(sampleData);
    }
    //Load sample data
    

}