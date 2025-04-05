namespace ForecastStation;

public interface IObservable<T>
{
    public void AddObserver(IObserver<T> observer);
    public void NotifyObservers();
    public void RemoveObserver(IObserver<T> observer);
}