namespace CoffeeMachine;

public class LatteDecorator : CoffeeDecorator
{
    public LatteDecorator(CoffeeOrder order) : base(order)
    {
        Cost = Order.Cost + 0.5m;
        CoffeeData.MilkVolume = Order.CoffeeData.MilkVolume + 60.0d;
    }
}