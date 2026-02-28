using System;

namespace ClassWork;

public class PcWeatherObserver: IObserver
{
    public void Update(double temperature)
    {
        Console.WriteLine($"[PC] The temperature is {temperature}");
    }
}