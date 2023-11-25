namespace CoffeeMachine;

public class CoffeeBuilder
{
    private CoffeeOrder _order;
    private readonly Dictionary<CoffeeType, CoffeeOrder> _supportCoffee = new()
    {
        { CoffeeType.Espresso, new EspressoDecorator(new CoffeeOrder()) },
        { CoffeeType.Americano, new AmericanoDecorator(
            new EspressoDecorator(
                new CoffeeOrder())) },
        { CoffeeType.Cappuccino, new EspressoDecorator(new CoffeeOrder()) },
        { CoffeeType.Latte, new EspressoDecorator(new CoffeeOrder()) }
    };

    public CoffeeBuilder(CoffeeType coffeeType)
    {
        if (!_supportCoffee.TryGetValue(coffeeType, out _order))
        {
            throw new NotSupportedException(
                "Данный тип коффе не поддерживается этой машиной!");
        }
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