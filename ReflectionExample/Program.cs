using System.Reflection;
using ReflectionExample;
using ReflectionExample.zUnit;

var product = new Product(12.0m, TypeOfProduct.Wood);

Console.WriteLine(product);

var version = Console.ReadLine();

var productType  = typeof(Product);

var method = productType.GetMethods()
    .FirstOrDefault(m => m.GetCustomAttributes<MethodVersionAttribute>().Any(atr => atr.Version == version));

if (method != null)
{
    string result = (string) method.Invoke(product, null)!;

    Console.WriteLine(result);
}

//ZUnit.Run();












































































































































/*while (true)
{
    
    Console.WriteLine("meow\b\b\b\b");
}*/

