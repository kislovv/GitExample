namespace CoffeeMaker;

/* зерна - 8 гм 
вода - 50мл
молоко - 100мл
Сахар - 5 мг

Цены(за 200 мл):
зерна - 10.0
Вода - 5.0
Молоко - 20.0
Сахар - 5.0

Эспрессо: 1зерно + 1вода
Капуччино: 1зерно + 1вода + 1молоко
Латте: 1зерно + 2молоко
*/

public class CoffeeMachine
{
    private Account _account =  new Account();
    private IngredientStorage _storage = new IngredientStorage();
    private List<CoffeeOrder> _orders = new List<CoffeeOrder>();

    public int CreateOrder(Type type, Size size)
    {
        double k = (double)size / (double)Size.S;
        CoffeeOrder order = new CoffeeOrder();
        Coffee coffee = new Coffee()
        {
            Type = type,
            Size = size,
        };
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

        return -1;
    }
    
}