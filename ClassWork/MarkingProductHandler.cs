using System;

namespace ClassWork;

public class MarkingProductHandler : IHandler<Product>
{
    public IHandler<Product>? Next { get; set; }
    public void Handle(Product input)
    {
        input.Id = Guid.NewGuid();
        Next?.Handle(input);
    }
}