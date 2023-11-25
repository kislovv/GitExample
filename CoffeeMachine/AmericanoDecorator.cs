namespace CoffeeMachine;

public class AmericanoDecorator : CoffeeDecorator
{
    public AmericanoDecorator(CoffeeOrder order) : base(order)
    {
        Cost = order.Cost + 0.15m;
        WaterValue += order.WaterValue + 30.0d;
    }
}