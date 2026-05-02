namespace ClassWork;

public class Vector
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector()
        {
            X = v1.X + v2.X,
            Y = v1.Y + v2.Y,
            Z = v1.Z + v2.Z
        };
    }
    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector()
        {
            X = v1.X - v2.X,
            Y = v1.Y - v2.Y,
            Z = v1.Z - v2.Z
        };
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    public override bool Equals(object? obj)
    {
        return obj is Vector o && o.X == X && o.Y == Y && o.Z == Z;
    }

    public void operator += (int value)
    {
        X += value;
        Y += value;
        Z += value;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
    }
}