namespace OzonChain;

public class CheckOrderStorageHandler(List<Product> products) : IHandler<Order>
{
    private readonly List<Product> _products = products;
    public IHandler<Order>? Successor { get; set; }

    public Order Handle(Order element)
    {
        foreach (var product in _products)
        {
            if (product.Name != element.Name)
            {
                continue;
            }
            element.Price = product.Price;
            _products.Remove(product);
            
            return Successor != null 
                ? Successor.Handle(element) 
                : element;
        }
        throw new NotSupportedException(
            "No Product by storage");
    }
}