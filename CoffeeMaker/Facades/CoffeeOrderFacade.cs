using CoffeeMaker.Factories;
using CoffeeMaker.Repositories;

namespace CoffeeMaker.Facades;

public class CoffeeOrderFacade : ICoffeeOrderFacade
{
    private readonly ICoffeeOrderRepository _coffeeOrderRepository =  new FileCoffeeOrderRepository("test");
    private readonly Account _account = new Account();
    private readonly IngredientStorage _ingredientStorage = new IngredientStorage();
    private readonly ICoffeeOrderFactory _factory = new CoffeeOrderFactory(new CoffeeFactory());

    public int CreateOrder(Type type, Size size)
    {
        var order = _factory.CreateCoffeeOrder(type, size);
        _coffeeOrderRepository.AddOrder(order);
        
        return order.Number;
    }

    public bool AcceptPay(int orderNumber, double deposit)
    {
        CoffeeOrder? order = _coffeeOrderRepository.Get(orderNumber);
        
        if (order == null)
        {
            return false;
        }

        order.OrderStatus = OrderStatus.InProgress;
        order.Deposit += deposit;
        
        return true;
    }

    public CoffeePrepareResult PrepareCoffee(int orderNumber)
    {
        CoffeeOrder? order = _coffeeOrderRepository.Get(orderNumber);

        if (order == null)
        {
            return new CoffeePrepareResult();
        }

        order.OrderStatus = OrderStatus.InProgress;
        
        if (order.Price > order.Deposit || 
            !_ingredientStorage.TakeIngredient(order.Coffee.Ingredient))
        {
            order.OrderStatus = OrderStatus.Canceled;
            return new CoffeePrepareResult();
        }

        _account.Deposit(order.Price);
        order.OrderStatus = OrderStatus.Completed;
        
        return new CoffeePrepareResult()
        {
            Coffee = order.Coffee,
            IsPrepared = true,
            Change = order.Deposit - order.Price,
        };
    }

    public void AddAdditional(int orderNumber, double price, AdditionalType additionalType)
    {
        CoffeeOrder? order = _coffeeOrderRepository.Get(orderNumber);
        if (order == null)
        {
            return;
        }
        
        var additionalFacade = AdditionalFacadeFactory.GetAdditionalFacade(additionalType);
        
        additionalFacade.AddAdditional(order.Coffee.Ingredient);
        order.Price += price;
        order.OrderStatus = OrderStatus.Ready;
    }
}