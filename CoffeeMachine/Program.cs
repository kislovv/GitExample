using System.Reflection;
using CoffeeMachine;

var myOrder = new CoffeeBuilder(CoffeeType.Espresso)
    .AddMilk()
    .AddSugar()
    .AddMilk()
    .Build();

Type type = typeof (string);
Type[] parameterTypes = { typeof (string) };
MethodInfo method = type.GetMethod ("IsNullOrWhiteSpace", 
    BindingFlags.Static|BindingFlags.Public, parameterTypes);
object[] arguments = { "Any" };
object returnValue = method.Invoke (null, arguments);
Console.WriteLine (returnValue);
