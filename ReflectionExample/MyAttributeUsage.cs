namespace ReflectionExample;

public class MyAttributeUsage(string name, int count): Attribute
{
    public string Name { get; set; } = name;
    public int Count { get; set; } = count;
}