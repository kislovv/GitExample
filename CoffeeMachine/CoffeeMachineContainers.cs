namespace CoffeeMachine;

internal class CoffeeMachineContainers
{
    public CoffeeData CoffeeData { get; set; } 
    public CoffeeMachineContainers()
    {
        CoffeeData = new CoffeeData
        {
            BeansVolume = 500,
            MilkVolume = 500,
            SugarVolume = 100,
            WaterValue = 1000
        };
    }
    
}