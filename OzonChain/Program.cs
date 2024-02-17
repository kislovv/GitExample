using OzonChain;

var products = new List<Product>
{
    new Product
    {
        Name = "Apple",
        Price = 15.6m
    },
    new Product
    {
        Name = "Pizza",
        Price = 205.15m
    },
    new Product
    {
        Name = "Bread",
        Price = 30.15m
    }
};

var order = new Order
{
    Name = "Pizza"
};

var orderHandlerAggregator = new HandlerAggregator<Order>(new CheckOrderStorageHandler(products));
orderHandlerAggregator.AddHandler(new ScanOrderHandler());
orderHandlerAggregator.AddHandler(new ResolveOrderHandler());

var result = orderHandlerAggregator.StartChain(order);
    
