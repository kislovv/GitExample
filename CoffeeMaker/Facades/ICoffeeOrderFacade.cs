namespace CoffeeMaker.Facades;

public interface ICoffeeOrderFacade
{
    int CreateOrder(Type type, Size size);
    
    bool AcceptPay(int orderNumber, double deposit);

    CoffeePrepareResult PrepareCoffee(int orderNumber);

    void AddAdditional(int orderNumber, double price, AdditionalType additionalType);
}