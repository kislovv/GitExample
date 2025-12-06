namespace CoffeeMaker.Factories;

public interface ICoffeeOrderFactory
{
    CoffeeOrder CreateCoffeeOrder(Type type, Size size);
}