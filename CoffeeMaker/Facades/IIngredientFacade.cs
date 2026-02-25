namespace CoffeeMaker.Facades;

public interface IIngredientFacade
{
    void AddAdditional(Ingredient ingredient, AdditionalType additionalType);
}