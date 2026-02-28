using System;
using System.Collections.Generic;

namespace ClassWork;

public delegate void UpdateTemperatureDelegate(double temperature);

public class WeatherObservable
{
    private double _temperature;
    // private List<IObserver> _observers = [];
    public event UpdateTemperatureDelegate UpdateTemperatureDelegate;

    public WeatherObservable(double temperature)
    {
        _temperature = temperature;
    }
    /*
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }
    */
    /*
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }

    }
    */
    /*
    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }
    */
    
    public void UpdateTemperature()
    {
        double delta = new Random().NextDouble();
        double newTemperature = Math.Round(_temperature + delta, 2);
        if (Math.Abs(_temperature - newTemperature) > 0.1)
        {
            _temperature = newTemperature;
            UpdateTemperatureDelegate?.Invoke(_temperature);
        }
    }
}