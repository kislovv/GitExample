namespace ClassWork;

public class IntegerCalculator : IGenericCalculator<int>
{
    public object Add(object a, object b)
    {
        var args = GetArguments(a, b); 
        
        return args.a + args.b;
    }

    public object Subtract(object a, object b)
    {
        var args = GetArguments(a, b); 
        
        return args.a - args.b;
    }

    public object Multiply(object a, object b)
    {
        var args = GetArguments(a, b); 
        
        return args.a * args.b;
    }

    public object Divide(object a, object b)
    {
        var args = GetArguments(a, b); 
        
        return args.a / args.b;
    }
    
    private void CheckArguments(object a, object b)
    {
        if (a == null || b == null)
        {
            throw new System.ArgumentNullException(nameof(a));
        }
    }

    private (int a, int b) GetArguments(object a, object b)
    {
        CheckArguments(a, b);
        
        if (a is int aInt && b is int bInt)
        {
            return (aInt, bInt); 
        }
        throw new System.ArgumentNullException(nameof(a));
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }
}