namespace CoffeeMachine;

public class CappuccinoDecorator : CoffeeDecorator
{
    public CappuccinoDecorator(CoffeeOrder order) : base(order)
    {
        Cost = Order.Cost + 0.45m;
        CoffeeData.WaterValue = Order.CoffeeData.WaterValue + 30.0d;
        CoffeeData.MilkVolume = Order.CoffeeData.MilkVolume + 30.0d;
    }
}