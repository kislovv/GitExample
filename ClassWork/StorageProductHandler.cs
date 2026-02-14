using System;
using System.Collections.Generic;

namespace ClassWork;

public class StorageProductHandler : IHandler<Product>
{
    private List<Product> _products;
    
    public StorageProductHandler(List<Product> products)
    {
        _products = products;
    }
    public IHandler<Product>? Next { get; set; }
    public void Handle(Product input)
    {
        foreach (var product in _products)
        {
            if (product.Name == input.Name)
            {
                input.Price = product.Price;
                Next?.Handle(input);
                _products.Remove(product);
                return;
            }
        }
        
        throw new ArgumentException("Product not found");
    }
}