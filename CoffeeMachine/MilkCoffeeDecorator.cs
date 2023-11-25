namespace CoffeeMachine;

public class MilkCoffeeDecorator : CoffeeDecorator
{
    public MilkCoffeeDecorator(CoffeeOrder order) : base(order)
    {
        Cost = Order.Cost + 0.15m;
        CoffeeData.MilkVolume = Order.CoffeeData.MilkVolume + 20.0d;
    }
}