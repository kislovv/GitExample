namespace SuperPuperCalculator;

public class IntegerCalculator : ICalculator
{
    public object Add(object a, object b)
    {
        if (a is int aInt && b is int bInt)
        {
            return aInt + bInt;
        }
        
        throw new ArgumentException($"{nameof(a)} or {nameof(b)} must be an integer");
    }

    public object Subtract(object a, object b)
    {
        throw new NotImplementedException();
    }

    public object Multiply(object a, object b)
    {
        throw new NotImplementedException();
    }

    public object Divide(object a, object b)
    {
        throw new NotImplementedException();
    }
}