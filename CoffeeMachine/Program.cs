using CoffeeMachine;

var myOrder = new CoffeeBuilder(CoffeeType.Espresso)
    .AddMilk()
    .AddSugar()
    .AddMilk()
    .Build();

Console.WriteLine(myOrder.Cost);
