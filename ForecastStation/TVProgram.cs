namespace ForecastStation;

public class TVProgram: IObserver<double>
{
    public void Update(double temperature)
    {
        Console.WriteLine($"TVForecast temperature: {temperature}");
    }
}