namespace OzonChain;

public class ResolveOrderHandler: IHandler<Order>
{
    public IHandler<Order>? Successor { get; }
    public Order Handle(Order element)
    {
        Console.WriteLine($"{element.Id}: Выдан продукт {element.Name}. Цена:{element.Price}");

        return element;
    }
}