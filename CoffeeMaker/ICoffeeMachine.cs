namespace CoffeeMaker;

public interface ICoffeeMachine
{
    int CreateOrder(Type type, Size size);
    bool AcceptPay(int orderNumber, double deposit);
    void AddWater(int orderNumber);
    void AddMilk(int orderNumber);
    void AddBeans(int orderNumber);
    void AddSugar(int orderNumber);
    CoffeePrepareResult PrepareCoffee(int orderNumber);
}