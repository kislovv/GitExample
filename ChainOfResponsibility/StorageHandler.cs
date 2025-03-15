namespace ChainOfResponsibility;

public class StorageHandler: BaseHandler<Order>
{
    private List<Product> _products;
    public StorageHandler(List<Product> products, IHandler<Order>? next) : base(next)
    {
        _products = products;
    }
    
    public override void Handle(Order element)
    {
        if (!_products.Contains(element.Product))
        {
            Console.WriteLine($"Product {element.Product} does not exist");
            return;
        }
        base.Handle(element);
        _products.Remove(element.Product);
        Console.WriteLine($"Product {element.ToString()} has been sold");
    }
}