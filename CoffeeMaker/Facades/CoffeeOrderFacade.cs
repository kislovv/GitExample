namespace CoffeeMaker.Facades;

public class CoffeeOrderFacade : ICoffeeOrderFacade
{
    private readonly ICoffeeOrderRepository _coffeeOrderRepository;

    public CoffeeOrderFacade(ICoffeeOrderRepository coffeeOrderRepository)
    {
        _coffeeOrderRepository = coffeeOrderRepository;
    }

    public bool AcceptPay(int orderNumber, double deposit)
    {
        CoffeeOrder? order = _coffeeOrderRepository.Get(orderNumber);
        
        if (order == null)
        {
            return false;
        }

        order.OrderStatus = OrderStatus.InProgress;
        order.Deposit += deposit;
        
        return true;
    }
}