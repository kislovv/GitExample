namespace Generics;

public class Generator<T> where T: new()
{
    public List<T> Generate(int count)
    {
        List<T> result = new List<T>();
        for (int i = 0; i < count; i++)
        {
            T item = new T();
            result.Add(item);
        }
        
        return result;
    }
}