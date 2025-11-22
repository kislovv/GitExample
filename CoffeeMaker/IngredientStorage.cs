namespace CoffeeMaker;

public class IngredientStorage
{
    private readonly Ingredient _ingredient;
    private const double IngrediantMaxValue = 5000;

    public IngredientStorage()
    {
        _ingredient = new Ingredient()
        {
            Beans = IngrediantMaxValue,
            Milk = IngrediantMaxValue,
            Sugar = IngrediantMaxValue,
            Water = IngrediantMaxValue,
        };
    }

    public bool CheckIngredient(Ingredient ingredient)
    {
        if (ingredient.Beans > _ingredient.Beans)
        {
            return false;
        }

        if (ingredient.Milk > _ingredient.Milk)
        {
            return false;
        }

        if (ingredient.Sugar > _ingredient.Sugar)
        {
            return false;
        }

        if (ingredient.Water > _ingredient.Water)
        {
            return false;
        }
        
        return true;
    }

    public void UpdateIngredient()
    {
        _ingredient.Milk = IngrediantMaxValue;
        _ingredient.Sugar = IngrediantMaxValue;
        _ingredient.Water = IngrediantMaxValue;
        _ingredient.Beans = IngrediantMaxValue;
    }

    public bool TakeIngredient(Ingredient ingredient)
    {
        if (CheckIngredient(ingredient))
        {
            _ingredient.Milk -= ingredient.Milk;
            _ingredient.Sugar -= ingredient.Sugar;
            _ingredient.Water -= ingredient.Water;
            _ingredient.Beans -= ingredient.Beans;
            return true;
        }

        return false;
    }
    
}