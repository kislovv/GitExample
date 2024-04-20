using CustomerLogger;

var calculator = new Calculator(new FileLogger("log.txt"));

var a = calculator.Add(1, 2);
var b = calculator.Add(2, 2);
var c = calculator.Add(3, 2);
var d = calculator.Remove(5, 1);

var consoleLogger = new ConsoleLoggerDecorator(new ConsoleLogger());
var customLogger = new ConsoleLoggerDecorator(new FileLoggerDecorator(new ConsoleLogger(), "log.txt"));
customLogger.Log("usdasdadv");

var customLoggerv2 = new LoggerBuilder(new ConsoleLogger())
    .WithFile("log.txt")
    .WithConsole()
    .Build();
customLoggerv2.Log("privetiki!!!"); 
