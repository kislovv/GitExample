namespace CoffeeMachine;

public class SugarCoffeeDecorator : CoffeeDecorator
{
    public SugarCoffeeDecorator(CoffeeOrder order) : base(order)
    {
        Cost = order.Cost + 0.05m;
        SugarVolume = order.SugarVolume + 5.0d;
    }
}