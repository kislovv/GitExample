using System.Text.Json;

namespace CoffeeMaker.Repositories;

public class FileCoffeeOrderRepository : ICoffeeOrderRepository
{
    private readonly string _filePath;

    public FileCoffeeOrderRepository(string filePath)
    {
        _filePath = filePath;
    }

    public void AddOrder(CoffeeOrder coffeeOrder)
    {
        File.AppendAllText(_filePath, 
            JsonSerializer.Serialize(new List<CoffeeOrder> { coffeeOrder }));
    }

    public CoffeeOrder? Get(int number)
    {
        var orders =  JsonSerializer.Deserialize<List<CoffeeOrder>>(File.ReadAllText(_filePath));
        foreach (var order in orders)
        {
            if (order.Number == number)
            {
                return order;
            }
        }
        
        return null;
    }
}