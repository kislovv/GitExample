namespace OzonChain;

public class ScanOrderHandler(IHandler<Order>? successor) : IHandler<Order>
{
    public IHandler<Order>? Successor { get; } = successor;

    public Order Handle(Order element)
    {
        element.Id = Guid.NewGuid();

        return Successor != null 
            ? Successor.Handle(element) 
            : element;
    }
}