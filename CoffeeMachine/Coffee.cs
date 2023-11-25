namespace CoffeeMachine;

public abstract class Coffee : ICloneable
{
    public double WaterValue { get; private protected set; }
    public double MilkVolume { get; private protected set; }
    public double SugarVolume { get; private protected set; }
    public double BeansVolume { get; private protected set; }
    public object Clone()
    {
        return MemberwiseClone();
    }
}