namespace CoffeeMachine;

public class SugarCoffeeDecorator : CoffeeDecorator
{
    public SugarCoffeeDecorator(CoffeeOrder order) : base(order)
    {
        Cost = _order.Cost + 0.05m;
        SugarVolume = _order.SugarVolume + 5.0d;
    }
}