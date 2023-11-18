namespace CoffeeMachine;

public class MilkCoffeeDecorator : CoffeeDecorator
{
    public MilkCoffeeDecorator(CoffeeOrder order) : base(order)
    {
        Cost = order.Cost + 0.15m;
        MilkVolume = order.MilkVolume + 20.0d;
    }
}