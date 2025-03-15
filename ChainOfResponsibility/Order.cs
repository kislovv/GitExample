namespace ChainOfResponsibility;

public class Order
{
    public Guid Number { get; set; }
    public required Product Product { get; set; }

    public override string ToString()
    {
        return $"Number: {Number}, Product Name: {Product.Name}, Product Price: {Product.Price}";
    }
}