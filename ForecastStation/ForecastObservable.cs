namespace ForecastStation;

public class ForecastObservable: IObservable<double>
{
    private double _temperature = new Random().NextDouble()*30;
    private List<IObserver<double>> _observers = new();

    public void AddObserver(IObserver<double> observer)
    {
        _observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
    }

    public void RemoveObserver(IObserver<double> observer)
    {
        try
        {
            _observers.Remove(observer);
        }
        catch
        {
            throw new Exception("Observer could not be removed");
        }
    }

    public void UpdateTemperature()
    {
        _temperature = Math.Round(new Random().NextDouble()*30);
        NotifyObservers();
    }
}