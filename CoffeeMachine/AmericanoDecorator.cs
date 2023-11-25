namespace CoffeeMachine;

public class AmericanoDecorator : CoffeeDecorator
{
    public AmericanoDecorator(CoffeeOrder order) : base(order)
    {
        Cost = Order.Cost + 0.15m;
        CoffeeData.WaterValue += Order.CoffeeData.WaterValue + 30.0d;
    }
}