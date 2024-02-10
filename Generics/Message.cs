namespace Generics;

public class Message
{
    public string? Title { get; init; }
    public string Data { get; init; } = null!;


    public override string ToString()
    {
        return $"{Title}: {Data}";
    }
}