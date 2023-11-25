namespace CoffeeMachine;

public interface ICoffeeMachine
{
    CoffeeOrder ChooseCoffee(CoffeeType coffeeType);
    CoffeeOrder AddSugar();
    CoffeeOrder AddMilk();
    (bool isSuccess, string check) TryPay(decimal money, out Coffee coffee);
}