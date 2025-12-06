using System.Diagnostics;

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
    

    public int CreateOrder(Type type, Size size)
    {
        double k = (double)size / (double)Size.S;
        
        Coffee coffee = new Coffee()
        {
            Type = type,
            Size = size,
        };
        
        ChangeCoffeName(type, coffee);
        CreateCoffeeIngredients(type, coffee, k);
        
        CoffeeOrder order = new CoffeeOrder
        {
            Price = GetCoffeOrderPrice(coffee),
            Coffee = coffee,
            OrderStatus = OrderStatus.Created
        };

        _orderRepository.AddOrder(order);
        
        return order.Number;
    }

    private static double GetCoffeOrderPrice(Coffee coffee)
    {
        return coffee.Ingredient.Beans / 8 * 10 + 
               coffee.Ingredient.Milk / 100 * 20 +
               coffee.Ingredient.Sugar / 5 * 5 +
               coffee.Ingredient.Water / 50 * 5;
    }

    private static void CreateCoffeeIngredients(Type type, Coffee coffee, double k)
    {
        switch (type)
        {
            case Type.Cappuccino:
                coffee.Ingredient = new Ingredient()
                {
                    Beans = 8 * k,
                    Water = 50 * k,
                    Milk = 100 * k
                };
                break;
            case Type.Latte:
                coffee.Ingredient = new Ingredient()
                {
                    Beans = 8 * k,
                    Milk = 2 * 100 * k,
                };
                break;
            case Type.Espresso:
                coffee.Ingredient = new Ingredient()
                {
                    Beans = 8 * k,
                    Water = 50 * k,
                };
                break;
        }
    }

    private static void ChangeCoffeName(Type type, Coffee coffee)
    {
        switch (type)
        {
            case Type.Cappuccino:
                coffee.Name = "Каппучино";
                break;
            case Type.Latte:
                coffee.Name = "Латте";
                break;
            case Type.Espresso:
                coffee.Name = "Еспрессо";
                break;
        }
    }

    public bool AcceptPay(int orderNumber, double deposit)
    {
        CoffeeOrder? order = _orderRepository.Get(orderNumber);
        
        if (order == null)
        {
            return false;
        }

        order.OrderStatus = OrderStatus.InProgress;
        order.Deposit += deposit;
        
        return true;
    }

    public void AddWater(int orderNumber)
    {
        CoffeeOrder? order = _orderRepository.Get(orderNumber);
        
        if (order == null)
        {
            return;
        }

        order.Coffee.Ingredient.Water += 50;
        order.Price += 5;
        order.OrderStatus = OrderStatus.Ready;
    }

    public void AddMilk(int orderNumber)
    {
        CoffeeOrder? order = _orderRepository.Get(orderNumber);
        
        if (order == null)
        {
            return;
        }

        order.Coffee.Ingredient.Milk += 100;
        order.Price += 20;
        order.OrderStatus = OrderStatus.Ready;
    }

    public void AddBeans(int orderNumber)
    {
        CoffeeOrder? order = _orderRepository.Get(orderNumber);
        
        if (order == null)
        {
            return;
        }

        order.Coffee.Ingredient.Beans += 8;
        order.Price += 10;
        order.OrderStatus = OrderStatus.Ready;
    }

    public void AddSugar(int orderNumber)
    {
        CoffeeOrder? order = _orderRepository.Get(orderNumber);
        
        if (order == null)
        {
            return;
        }

        order.Coffee.Ingredient.Sugar += 5;
        order.Price += 5;
        order.OrderStatus = OrderStatus.Ready;
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
}