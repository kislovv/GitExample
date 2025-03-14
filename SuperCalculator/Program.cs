namespace SuperCalculator;

class Program
{
    static void Main(string[] args)
    {
        var container = new Container();
        container.Register<Calculator>();
        container.Register<ILogger, ConsoleLogger>();
        var calculator = container.Resolve<Calculator>();
        calculator.Add(2, 3);
    }
}