namespace CoffeeMaker;

public interface ICoffeeOrderRepository
{
    void AddOrder(CoffeeOrder coffeeOrder);
    CoffeeOrder? Get(int number);
}