namespace CoffeeMachine;

public class EspressoDecorator : CoffeeDecorator
{
    public EspressoDecorator(CoffeeOrder order) : base(order)
    {
        Cost = order.Cost + 1;
        BeansVolume = order.BeansVolume + 20.0d;
        WaterValue += order.WaterValue + 30.0d;
    }
}