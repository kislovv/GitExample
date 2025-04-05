namespace ForecastStation;

public class DelegateForecastObservable : IDelegateObservable
{
    private double _temperature = 0;
    public event Action<double> OnUpdateTemp = _=> { };

    public void NotifyObservers()
    {
        OnUpdateTemp(_temperature);
    }
    
    public void UpdateTemperature()
    {
        _temperature = Math.Round(new Random().NextDouble()*30);
        NotifyObservers();
    }
}