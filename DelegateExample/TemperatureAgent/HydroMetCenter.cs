namespace DelegateExample.TemperatureAgent;

public class HydroMetCenter : IObservable
{
    private double temp = new Random().NextDouble() * new Random().Next(-10, 10);
    
    public void NotifyObservers()
    {
        NotifyUpdate?.Invoke(temp);
    }

    public event IObservable.Update? NotifyUpdate;

    public void UpdateTemp()
    {
        var newTemp = new Random().NextDouble() * new Random().Next(-10, 10);
        if (newTemp != temp)
        {
            temp = newTemp;
            NotifyObservers();
        }
    }
}