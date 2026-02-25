using CoffeeMaker.Helpers;

namespace CoffeeMaker.Facades;

public class BeansAdditionalFacade : IAdditionalFacade
{
    public void AddAdditional(Ingredient ingredient)
    {
        ingredient.Beans += BaseIngredientMeta.Beans;
    }
}