using System.Collections;

namespace CoffeeMachine;

public class CoffeeDataComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is not CoffeeData cd1)
        {
            throw new ArgumentException(nameof(x));
        }
        if (y is not CoffeeData cd2)
        {
            throw new ArgumentException(nameof(x));
        }

        if (cd1.BeansVolume > cd2.BeansVolume
            && cd1.MilkVolume > cd2.MilkVolume
            && cd1.SugarVolume > cd2.SugarVolume
            && cd1.WaterValue > cd2.WaterValue)
        {
            return 1;
        }

        if (Math.Abs(cd1.BeansVolume - cd2.BeansVolume) < 0.0001
            && Math.Abs(cd1.MilkVolume - cd2.MilkVolume) < 0.0001
            && Math.Abs(cd1.SugarVolume - cd2.SugarVolume) < 0.0001
            && Math.Abs(cd1.WaterValue - cd2.WaterValue) < 0.0001)
        {
            return 0;
        }

        return -1;
    }
}