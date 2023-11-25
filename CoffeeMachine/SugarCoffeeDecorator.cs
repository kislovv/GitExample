namespace CoffeeMachine;

public class SugarCoffeeDecorator : CoffeeDecorator
{
    public SugarCoffeeDecorator(CoffeeOrder order) : base(order)
    {
        Cost = Order.Cost + 0.05m;
        CoffeeData.SugarVolume = Order.CoffeeData.SugarVolume + 5.0d;
    }
}