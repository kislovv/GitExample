namespace OzonChain;

public class ScanOrderHandler : IHandler<Order>
{
    public IHandler<Order>? Successor { get; set; }

    public Order Handle(Order element)
    {
        element.Id = Guid.NewGuid();

        return Successor != null 
            ? Successor.Handle(element) 
            : element;
    }
}