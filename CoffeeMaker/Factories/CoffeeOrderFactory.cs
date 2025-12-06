namespace CoffeeMaker.Factories;

public class CoffeeOrderFactory : ICoffeeOrderFactory
{
    
    private readonly ICoffeeFactory _coffeeFactory;

    public CoffeeOrderFactory(ICoffeeFactory coffeeFactory)
    {
        _coffeeFactory = coffeeFactory;
    }
    public CoffeeOrder CreateCoffeeOrder(Type type, Size size)
    {
        double k = (double)size / (double)Size.S;
        
        Coffee coffee = _coffeeFactory.CreateCoffee(type, size, k);
        
        CoffeeOrder order = new CoffeeOrder
        {
            Price = GetCoffeeOrderPrice(coffee),
            Coffee = coffee,
            OrderStatus = OrderStatus.Created
        };
        
        return order;
    }
    
    private static double GetCoffeeOrderPrice(Coffee coffee)
    {
        return coffee.Ingredient.Beans / 8 * 10 + 
               coffee.Ingredient.Milk / 100 * 20 +
               coffee.Ingredient.Sugar / 5 * 5 +
               coffee.Ingredient.Water / 50 * 5;
    }
}