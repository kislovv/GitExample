namespace CoffeeMachine;

internal static class CoffeeMachineContainers
{
    public static CoffeeData CoffeeData { get; set; } = new()
    {
        BeansVolume = 500,
        MilkVolume = 500,
        SugarVolume = 100,
        WaterValue = 1000
    };
}