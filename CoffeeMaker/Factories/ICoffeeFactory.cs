namespace CoffeeMaker.Factories;

public interface ICoffeeFactory
{
    Coffee CreateCoffee(Type type, Size size, double k);
}