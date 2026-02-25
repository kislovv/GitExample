using CoffeeMaker.Helpers;

namespace CoffeeMaker.Facades;

public class WaterAdditionalFacade : IAdditionalFacade
{
    public void AddAdditional(Ingredient ingredient)
    {
        ingredient.Water += BaseIngredientMeta.Water;
    }
}