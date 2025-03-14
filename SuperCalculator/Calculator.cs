namespace SuperCalculator;

public class Calculator(ILogger logger)
{
    public double Add(double a, double b)
    {
        logger.Log($"Adding a {a} to b {b}.");
        return a + b;
    }

    public double Substract(double a, double b)
    {
        logger.Log($"Substracting a {a} to b {b}.");
        return a - b;
    }
    
    public double Multiply(double a, double b)
    {
        logger.Log($"Multiplying a {a} to b {b}.");
        return a * b;
    }

    public double Divide(double a, double b)
    {
        logger.Log($"Dividing a {a} to b {b}.");
        return a / b;
    }
}