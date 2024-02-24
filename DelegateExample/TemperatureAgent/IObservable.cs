namespace DelegateExample.TemperatureAgent;

public interface IObservable
{
    void NotifyObservers();

    delegate void Update(double temperature);

    event Update NotifyUpdate;
}