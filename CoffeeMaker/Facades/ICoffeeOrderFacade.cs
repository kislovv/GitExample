namespace CoffeeMaker.Facades;

public interface ICoffeeOrderFacade
{
    bool AcceptPay(int orderNumber, double deposit);
}