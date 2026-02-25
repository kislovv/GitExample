using CoffeeMaker.Helpers;

namespace CoffeeMaker.Facades;

public class SugarAdditionalFacade : IAdditionalFacade
{
    public void AddAdditional(Ingredient ingredient)
    {
        ingredient.Sugar += BaseIngredientMeta.Sugar;
    }
}