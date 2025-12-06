namespace CoffeeMaker.Factories;

public class CoffeeFactory : ICoffeeFactory
{
    public Coffee CreateCoffee(Type type, Size size, double k)
    {
        Coffee coffee = new Coffee()
        {
            Type = type,
            Size = size,
        };
        
        ChangeCoffeName(type, coffee);
        CreateCoffeeIngredients(type, coffee, k);
        
        return coffee;
    }
    
    private static void CreateCoffeeIngredients(Type type, Coffee coffee, double k)
    {
        switch (type)
        {
            case Type.Cappuccino:
                coffee.Ingredient = new Ingredient()
                {
                    Beans = 8 * k,
                    Water = 50 * k,
                    Milk = 100 * k
                };
                break;
            case Type.Latte:
                coffee.Ingredient = new Ingredient()
                {
                    Beans = 8 * k,
                    Milk = 2 * 100 * k,
                };
                break;
            case Type.Espresso:
                coffee.Ingredient = new Ingredient()
                {
                    Beans = 8 * k,
                    Water = 50 * k,
                };
                break;
        }
    }

    private static void ChangeCoffeName(Type type, Coffee coffee)
    {
        switch (type)
        {
            case Type.Cappuccino:
                coffee.Name = "Каппучино";
                break;
            case Type.Latte:
                coffee.Name = "Латте";
                break;
            case Type.Espresso:
                coffee.Name = "Еспрессо";
                break;
        }
    }
}