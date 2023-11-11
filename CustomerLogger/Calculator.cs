namespace CustomerLogger;

public class Calculator
{
    private readonly ILogger _logger;
    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    public int Add(int a, int b)
    {
        _logger.Log($"{a} + {b} = {a + b}");
        return a + b;
    }

    public int Remove(int a, int b)
    {
        _logger.Log($"{a} - {b} = {a - b}");
        return a - b;
    }

    public int Divide(int a, int b)
    {
        _logger.Log($"{a} / {b} = {a / b}");
        return a / b;
    }

    public int Multiply(int a, int b)
    {
        _logger.Log($"{a} * {b} = {a * b}");
        return a * b;
    }
}