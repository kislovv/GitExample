namespace CoffeeMachine;

public class MilkCoffeeDecorator : CoffeeDecorator
{
    public MilkCoffeeDecorator(CoffeeOrder order) : base(order)
    {
        Cost = _order.Cost + 0.15m;
        MilkVolume = _order.MilkVolume + 20.0d;
    }
}