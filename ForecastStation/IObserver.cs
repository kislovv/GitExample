namespace ForecastStation;

public interface IObserver<T>
{
    public void Update(T information);
}