using System;

namespace ClassWork;

public class FinishProductHandler : IHandler<Product>
{
    public IHandler<Product>? Next { get; set; }
    public void Handle(Product input)
    {
        if (input.Id == Guid.Empty)
        {
            throw new ArgumentException("Product not Marked");
        }

        Console.WriteLine($"{input.Id}: {input.Name} was finished");
    }
}