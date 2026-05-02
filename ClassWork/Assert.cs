using System;

namespace ClassWork;

public static class Assert
{
    public static void Equal(object first, object second)
    {
        if (!object.Equals(first, second))
        {
            throw new AssertionException($"{first} != {second}");
        }
    }
}