namespace CoffeeMachine;

public interface ICoffeeMachine
{
    void ChooseCoffee(CoffeeType coffeeType);
    void AddSugar();
    void AddMilk();
    (bool isSuccess, string check) TryPay(decimal money, out Coffee coffee);
}