using SuperPuperCalculator;

namespace Generics;

public class PointCalculator : IGenericCalculator<Point>
{
    public Point Add(Point a, Point b)
    {
        return new Point()
        {
            X = a.X + b.X,
            Y = a.Y + b.Y
        };
    }

    public Point Subtract(Point a, Point b)
    {
        throw new NotImplementedException();
    }

    public Point Multiply(Point a, Point b)
    {
        throw new NotImplementedException();
    }

    public Point Divide(Point a, Point b)
    {
        throw new NotImplementedException();
    }
}