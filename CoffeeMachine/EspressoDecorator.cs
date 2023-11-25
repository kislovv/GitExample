namespace CoffeeMachine;

public class EspressoDecorator : CoffeeDecorator
{
    public EspressoDecorator(CoffeeOrder order) : base(order)
    {
        Cost = Order.Cost + 1;
        CoffeeData.BeansVolume = Order.CoffeeData.BeansVolume + 20.0d;
        CoffeeData.WaterValue += Order.CoffeeData.WaterValue + 30.0d;
    }
}