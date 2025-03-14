namespace CoffeeMachine;

public class CoffeeMachine : ICoffeeMachine
{
    private CoffeeMachineContainers _coffeeMachineContainers = new();
    private CoffeeBuilder? _coffeeBuilder;
    
    private readonly Brand _brand;
    public CoffeeMachine(Brand brand)
    {
        _brand = brand;
    }
    public void ChooseCoffee(CoffeeType coffeeType)
    {
        _coffeeBuilder = new CoffeeBuilder(coffeeType);
    }

    public void AddSugar()
    {
        if (_coffeeBuilder is null)
        {
            throw new InvalidOperationException("No coffee builder available.");
        }
        _coffeeBuilder = _coffeeBuilder.AddSugar();
    }

    public void AddMilk()
    {
        throw new NotImplementedException();
    }

    public (bool isSuccess, string check) TryPay(decimal money, out Coffee coffee)
    {
        CoffeeMachineAccount.Balance += money;
        throw new NotImplementedException();
    }
}