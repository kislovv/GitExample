namespace UnitTests;

public class Program
{
    public static void Main(string[] args)
    {

    }
    public static string[] GetFizzBuzzArray(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Некорректный входной параметр n");
        }
        var result = new string[n];

        for (var i = 1; i <= n; i++)
        {
            result[i-1] = i % 5 == 0 && i % 3 == 0
                ? "FizzBuzz"
                : i % 3 == 0
                    ? "Fizz"
                    : i % 5 == 0
                        ? "Buzz"
                        : i.ToString();
        }
        return result;
    }

    public int GetMajorityElement(int[] array)
    {
        return array.GroupBy(x => x)
            .ToDictionary(ints =>ints.Key, outs => outs.Count())
            .OrderBy(ints => ints.Value)
            .Last().Key;
    }
}