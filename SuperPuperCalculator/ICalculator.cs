namespace SuperPuperCalculator;

public interface ICalculator
{
    object Add(object a, object b);
    object Subtract(object a, object b);
    object Multiply(object a, object b);
    object Divide(object a, object b);
}