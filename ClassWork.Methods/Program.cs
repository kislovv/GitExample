using ClassWork.Methods;

var intSum = Calculator.Sum(1,2);
var strSum = Calculator.Sum("hello ", "world!");
var arraySum = Calculator.Sum(new int[]{1,2,3}, new int[]{4,5,6});

Console.WriteLine(intSum);
Console.WriteLine(strSum);
Console.WriteLine(string.Join(" ", arraySum));

