namespace ReflectionExample.zUnit;

public class AssertionException : Exception
{
    public AssertionException() : base(){}
    public AssertionException(string message) : base(message) { }
}