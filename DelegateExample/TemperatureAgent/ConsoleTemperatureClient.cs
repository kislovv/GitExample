namespace DelegateExample.TemperatureAgent;

public class ConsoleTemperatureClient : IObserver
{
    private readonly Guid _uniqueName = Guid.NewGuid();
    public void Update(double temp)
    {
        Console.WriteLine(
            $"{_uniqueName}: Температура изменилась! Новая температура {temp}");
    }
}