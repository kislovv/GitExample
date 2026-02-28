using System;

namespace ClassWork;

public class MobileWeatherObserver: IObserver
{
    public void Update(double temperature)
    {
        Console.WriteLine($"[MOBILE] The temperature is {temperature}");
    }
}