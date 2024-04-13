namespace DelegateExample.TemperatureAgent;

[HydroMedCenterMeta("Kazan", "2024-04-13")]
public class HydroMetCenter : IObservable
{
    private double temp = new Random().NextDouble() * new Random().Next(-10, 10);
    
    public void NotifyObservers()
    {
        Update?.Invoke(temp);
    }

    public event Action<double> Update;

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