namespace CoffeeMachine;

public abstract class CoffeeDecorator : CoffeeOrder
{
    private readonly CoffeeOrder _order;

    protected CoffeeDecorator(CoffeeOrder order)
    {
        _order = order;
    }
}