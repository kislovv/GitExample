using CustomerLogger;

var calculator = new Calculator(new FileLogger("log.txt"));

var a = calculator.Add(1, 2);
var b = calculator.Add(2, 2);
var c = calculator.Add(3, 2);
var d = calculator.Remove(5, 1);

