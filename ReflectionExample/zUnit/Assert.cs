namespace ReflectionExample.zUnit;

public static class Assert
{
    public static void Equals<T>(T a, T b)
    {
        if (a == null && b == null)
            return;
        else if (a == null || b == null || !a.Equals(b))
            throw new AssertionException("Parameters are not equal");
    }
}