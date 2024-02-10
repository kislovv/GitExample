namespace CoffeeMachine;

public class CoffeeMachine : ICoffeeMachine
{
    private CoffeeMachineContainers _coffeeMachineContainers = new();
    private readonly Brand _brand;
    public CoffeeMachine(Brand brand)
    {
        _brand = brand;
    }
    public CoffeeOrder ChooseCoffee(CoffeeType coffeeType)
    {
        throw new NotImplementedException();
    }

    public CoffeeOrder AddSugar()
    {
        throw new NotImplementedException();
    }

    public CoffeeOrder AddMilk()
    {
        throw new NotImplementedException();
    }

    public (bool isSuccess, string check) TryPay(decimal money, out Coffee coffee)
    {
        CoffeeMachineAccount.Balance += money;
        throw new NotImplementedException();
    }
}