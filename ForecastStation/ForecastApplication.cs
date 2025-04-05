namespace ForecastStation;

public class ForecastApplication: IObserver<double>
{
    public void Update(double information)
    {
        Console.WriteLine($"Forecast Station: {information}");
    }
}