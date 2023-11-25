namespace CoffeeMachine;

public class Coffee
{
    public Coffee(CoffeeType coffeeType)
    {
        CoffeeData = new CoffeeData
        {
            CoffeeType = coffeeType
        };
    }
    public CoffeeData CoffeeData { get; private protected set; }

    public override string ToString()
    {
        return CoffeeData.ToString();
    }
}


public class CoffeeData
{
    public CoffeeType CoffeeType { get; set; }
    public double WaterValue { get;  set; }
    public double MilkVolume { get;  set; }
    public double SugarVolume { get;  set; }
    public double BeansVolume { get;  set; }

    public override string ToString()
    {
        return $"Ваш кофе {CoffeeType} объемом {BeansVolume + WaterValue + SugarVolume + MilkVolume}.";
    }
}