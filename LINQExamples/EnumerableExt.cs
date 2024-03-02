namespace LINQExamples;

public static class EnumerableExt
{
    public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, 
        Func<T, bool> predicate)
    {
        var result = new List<T>();
        foreach (var temp in source)
        {
            if (predicate(temp))
            {
                result.Add(temp);
            }
        }

        return result;
    }
}