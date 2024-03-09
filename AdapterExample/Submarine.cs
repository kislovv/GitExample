namespace AdapterExample;

public class Submarine : ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Буль-буль-буль...");
    }
}