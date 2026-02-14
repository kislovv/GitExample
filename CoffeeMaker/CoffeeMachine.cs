using System.Diagnostics;
using CoffeeMaker.Facades;
using CoffeeMaker.Factories;

namespace CoffeeMaker;

/* зерна - 8 гм 
вода - 50мл
молоко - 100мл
Сахар - 5 мг

Цены(за 200 мл):
зерна - 10.0
Вода - 5.0
Молоко - 20.0
Сахар - 5.0

Эспрессо: 1зерно + 1вода
Капуччино: 1зерно + 1вода + 1молоко
Латте: 1зерно + 2молоко
*/

public class CoffeeMachine : ICoffeeMachine
{
    private readonly Account _account =  new Account();
    private readonly IngredientStorage _storage = new IngredientStorage();
    private readonly ICoffeeOrderRepository _orderRepository = new CoffeeOrderRepository();
    private readonly CoffeeOrderFactory _factory = new CoffeeOrderFactory(new CoffeeFactory());
    private readonly ICoffeeOrderFacade _coffeeOrderFacade;

    public CoffeeMachine()
    {
        _coffeeOrderFacade = new CoffeeOrderFacade(_orderRepository);
    }
    
    public int CreateOrder(Type type, Size size)
    {
        var order = _factory.CreateCoffeeOrder(type, size);
        _orderRepository.AddOrder(order);
        
        return order.Number;
    }

    public bool AcceptPay(int orderNumber, double deposit)
    {
        return _coffeeOrderFacade.AcceptPay(orderNumber, deposit);
    }

    public void AddWater(int orderNumber)
    {
        var ingredient = new Ingredient
        {
            Water = 50
        };
        
        AddAdditional(orderNumber, 5, ingredient);
    }

    public void AddMilk(int orderNumber)
    {
        var ingredient = new Ingredient
        {
            Milk = 100
        };
        
        AddAdditional(orderNumber, 20, ingredient);
    }

    public void AddBeans(int orderNumber)
    {
        var ingredient = new Ingredient
        {
            Beans = 8
        };
        
        AddAdditional(orderNumber, 10, ingredient);
    }

    public void AddSugar(int orderNumber)
    {
        var ingredient = new Ingredient
        {
            Sugar = 5
        };
        
        AddAdditional(orderNumber, 5, ingredient);
    }

    public CoffeePrepareResult PrepareCoffee(int orderNumber)
    {
        CoffeeOrder? order = _orderRepository.Get(orderNumber);

        if (order == null)
        {
            return new CoffeePrepareResult();
        }

        order.OrderStatus = OrderStatus.InProgress;
        
        if (order.Price > order.Deposit || 
            !_storage.TakeIngredient(order.Coffee.Ingredient))
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

    private void AddAdditional(int orderNumber, double price, Ingredient ingredient)
    {
        CoffeeOrder? order = _orderRepository.Get(orderNumber);
        
        if (order == null)
        {
            return;
        }

        order.Coffee.Ingredient.Sugar += ingredient.Sugar;
        order.Coffee.Ingredient.Water += ingredient.Water;
        order.Coffee.Ingredient.Beans += ingredient.Beans;
        order.Coffee.Ingredient.Milk += ingredient.Milk;
        order.Price += price;
        order.OrderStatus = OrderStatus.Ready;
    }
}