namespace CoffeeMachine;

public class EspressoDecorator : CoffeeDecorator
{
    public EspressoDecorator(CoffeeOrder order) : base(order)
    {
        Cost = _order.Cost + 1;
        BeansVolume = _order.BeansVolume + 20.0d;
        WaterValue += _order.WaterValue + 30.0d;
    }
}