namespace CoffeeMachine;

public abstract class CoffeeDecorator : CoffeeOrder
{
    protected readonly CoffeeOrder Order;

    protected CoffeeDecorator(CoffeeOrder order) : base(order.CoffeeData.CoffeeType)
    {
        Order = order;
        CoffeeData = order.CoffeeData;
    }
}