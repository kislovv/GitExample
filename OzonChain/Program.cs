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

var resolveHandler = new ResolveOrderHandler();
var scanHandler = new ScanOrderHandler(resolveHandler);
var checkOrderHandler = new CheckOrderStorageHandler(scanHandler, products);

var result = checkOrderHandler.Handle(order);
    
