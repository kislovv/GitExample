namespace ReflectionExample;

[MyAttributeUsage("sportsman", 2)]
public class Sportsman
{
    public string Name { get; set; }
    public int Category { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
    public string Sport { get; set; }
}