using CoffeeMachine;

var myOrder = new CoffeeBuilder()
    .AddMilk()
    .AddSugar()
    .AddMilk()
    .Build();

Console.WriteLine(myOrder.Cost);
