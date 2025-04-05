namespace ForecastStation;

class Program
{
    static void Main(string[] args)
    {
        ForecastApplication app = new ForecastApplication();
        TVProgram tv = new TVProgram();
        ForecastObservable station = new ForecastObservable();
        station.AddObserver(app);
        station.AddObserver(tv);
        station.UpdateTemperature();
        station.UpdateTemperature();
        station.UpdateTemperature();
        
        DelegateForecastObservable forecastObservable = new DelegateForecastObservable();
        forecastObservable.OnUpdateTemp += tv.Update;
        forecastObservable.OnUpdateTemp += app.Update;
        forecastObservable.UpdateTemperature();
        forecastObservable.UpdateTemperature();
        forecastObservable.UpdateTemperature();
    }
}