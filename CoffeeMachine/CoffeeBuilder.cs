namespace CoffeeMachine;

public class CoffeeBuilder
{
    private CoffeeOrder _order;
    private readonly Dictionary<CoffeeType, CoffeeOrder> _supportCoffee = new()
    {
        { CoffeeType.Espresso, new EspressoDecorator(new CoffeeOrder(CoffeeType.Espresso)) },
        { CoffeeType.Americano, new AmericanoDecorator(
            new EspressoDecorator(
                new CoffeeOrder(CoffeeType.Americano))) },
        { CoffeeType.Cappuccino, new CappuccinoDecorator(
            new EspressoDecorator(
                new CoffeeOrder(CoffeeType.Cappuccino))) },
        { CoffeeType.Latte, new LatteDecorator(
            new EspressoDecorator(
                new CoffeeOrder(CoffeeType.Latte))) }
    };

    public CoffeeBuilder(CoffeeType coffeeType)
    {
        if (!_supportCoffee.TryGetValue(coffeeType, out var order))
        {
            throw new NotSupportedException(
                "Данный тип коффе не поддерживается этой машиной!");
        }
        _order = order;
    }

    public CoffeeBuilder AddMilk()
    {
        _order = new MilkCoffeeDecorator(_order);
        return this;
    }

    public CoffeeBuilder? AddSugar()
    {
        _order = new SugarCoffeeDecorator(_order);
        return this;
    }

    public CoffeeOrder Build()
    {
        return _order;
    }
}