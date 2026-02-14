namespace CoffeeMaker;

public class CoffeeOrder
{
    public Coffee Coffee { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public int Number { get; set; }
    public double Price { get; set; }
    public double Deposit { get; set; }
}