using CoffeeMaker.Helpers;

namespace CoffeeMaker.Facades;

[Additional(AdditionalType.Milk)]
public class MilkAdditionalFacade : IAdditionalFacade
{
    public void AddAdditional(Ingredient ingredient)
    {
        ingredient.Milk += BaseIngredientMeta.Milk;
    }
}