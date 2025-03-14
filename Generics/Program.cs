using Generics;
using SuperPuperCalculator;

var calculator = new IntegerCalculator();
var result = calculator.Add(1, 2);
Console.WriteLine((bool)result);

var intPoint = new GenericPoint<int>()
{
    X = 1,
    Y = 2
};

var stringPoint = new GenericPoint<string>()
{
    X = "1",
    Y = "2"
};

var decimalPoint = new ThreeDPoint<decimal>()
{
    X = 1,
    Y = 2,
    Z = 3
};

var pointPoint = new ThreeDPoint<Point>()
{
    X = new Point{ X = 1, Y = 2 },
    Y = new Point{ X = 2, Y = 3 },
    Z = new Point{ X = 3, Y = 4 }
};