namespace DelegateExample.TemperatureAgent;

public interface IObservable
{
    void NotifyObservers();
    event Action<double> Update;
}