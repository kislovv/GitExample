namespace CoffeeMaker.Repositories;

public class CoffeeOrderRepository :  ICoffeeOrderRepository
{
    private readonly List<CoffeeOrder> _orders = new List<CoffeeOrder>();
    private int _count = 0;
    
    public void AddOrder(CoffeeOrder coffeeOrder)
    {
        coffeeOrder.Number = _count++;
        _orders.Add(coffeeOrder);
    }

    public CoffeeOrder? Get(int number)
    {
        CoffeeOrder? order = null;
        foreach (var ord in _orders)
        {
            if (ord.Number == number)
            {
                order = ord;
                break;
            }
        }

        if (order == null)
        {
            Console.WriteLine($"Order with number {number} not found");
        }
        
        return order;
    }
}