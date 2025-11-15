namespace OOP.Classes;

public abstract class Rocket : IRocket
{
    public Rocket(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public string Name { get; }
    public int Power { get; }
    
    public abstract void Check();
    public abstract void Start();
    public abstract void Stop();
}