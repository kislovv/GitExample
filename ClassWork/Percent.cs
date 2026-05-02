using System;

namespace ClassWork;

public readonly record struct Percent(decimal Value)
{
    public static implicit operator Percent(decimal value)
    {
        if (value < 0 || value > 100)
        {
            throw new ArgumentException("Value must be between 0 and 100");
        }
        return new Percent(value);
    }

    public static explicit operator decimal(Percent value)
    {
        return value.Value;
    }
}