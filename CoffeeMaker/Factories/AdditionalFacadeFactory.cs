using CoffeeMaker.Facades;

namespace CoffeeMaker.Factories;

public static class AdditionalFacadeFactory
{
    public static IAdditionalFacade GetAdditionalFacade(AdditionalType additionalType)
    {
        return additionalType switch
        {
            AdditionalType.Milk => new MilkAdditionalFacade(),
            AdditionalType.Beans => new BeansAdditionalFacade(),
            AdditionalType.Sugar => new SugarAdditionalFacade(),
            AdditionalType.Water => new WaterAdditionalFacade(),
            _ => throw new ArgumentOutOfRangeException("Unknown additional type")
        };
    }
}