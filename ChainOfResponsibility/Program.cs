﻿namespace ChainOfResponsibility;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product("Колбаса", 150));
        products.Add(new Product("Сыр", 500));
        products.Add(new Product("Батон", 10000));

        Order order = new Order()
        {
            Product = products[0]
        };

        var getProductHandler = new GetProductHandler(null);
        var markingProductHandler = new MarkingProductHandler(getProductHandler);
        var storageHandler = new StorageHandler(products, markingProductHandler);
        
        storageHandler.Handle(order);
    }
}