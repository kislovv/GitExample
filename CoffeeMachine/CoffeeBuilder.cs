namespace CoffeeMachine;

public class CoffeeBuilder
{
    private CoffeeOrder _order;

    public CoffeeBuilder()
    {
        _order = new EspressoDecorator(new CoffeeOrder());
    }

    public CoffeeBuilder AddMilk()
    {
        _order = new MilkCoffeeDecorator(_order);
        return this;
    }

    public CoffeeBuilder AddSugar()
    {
        _order = new SugarCoffeeDecorator(_order);
        return this;
    }

    public CoffeeOrder Build()
    {
        return _order;
    }
}