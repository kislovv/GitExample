namespace CoffeeMachine;

public abstract class Coffee
{
    public double WaterValue { get; private protected set; }
    public double MilkVolume { get; private protected set; }
    public double SugarVolume { get; private protected set; }
    public double BeansVolume { get; private protected set; }
}