namespace CoffeeMachine;

public abstract class CoffeeDecorator : CoffeeOrder
{
    protected readonly CoffeeOrder _order;

    protected CoffeeDecorator(CoffeeOrder order)
    {
        _order = (CoffeeOrder)order.Clone();
    }
}