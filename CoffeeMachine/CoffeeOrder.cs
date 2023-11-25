namespace CoffeeMachine;

public class CoffeeOrder : Coffee
{
    public CoffeeOrder(CoffeeType coffeeType) : base(coffeeType)
    {
    }
    public decimal Cost { get; set; }
    
    public override string? ToString()
    {
        return $"{CoffeeData} Стоимость: {Cost}";
    }
}