using CoffeeMaker.Facades;
using CoffeeMaker.Helpers;

namespace CoffeeMaker;

/* зерна - 8 гм 

Эспрессо: 1зерно + 1вода
Капуччино: 1зерно + 1вода + 1молоко
Латте: 1зерно + 2молоко
*/

public class CoffeeMachine : ICoffeeMachine
{

    private readonly ICoffeeOrderFacade _coffeeOrderFacade =  new CoffeeOrderFacade();
    
    public int CreateOrder(Type type, Size size)
    {
        return _coffeeOrderFacade.CreateOrder(type, size);
    }

    public bool AcceptPay(int orderNumber, double deposit)
    {
        return _coffeeOrderFacade.AcceptPay(orderNumber, deposit);
    }

    public void AddWater(int orderNumber)
    {
        _coffeeOrderFacade.AddAdditional(orderNumber, BasePriceMeta.Water, AdditionalType.Water);
    }

    public void AddMilk(int orderNumber)
    {
        _coffeeOrderFacade.AddAdditional(orderNumber, BasePriceMeta.Milk, AdditionalType.Milk);
    }

    public void AddBeans(int orderNumber)
    {
        _coffeeOrderFacade.AddAdditional(orderNumber, BasePriceMeta.Beans, AdditionalType.Beans);
    }

    public void AddSugar(int orderNumber)
    {
        _coffeeOrderFacade.AddAdditional(orderNumber, BasePriceMeta.Sugar, AdditionalType.Sugar);
    }

    public CoffeePrepareResult PrepareCoffee(int orderNumber)
    {
        return _coffeeOrderFacade.PrepareCoffee(orderNumber);
    }
}