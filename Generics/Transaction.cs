namespace Generics;

public class Transaction<TData>
{
    public Account? From { get; set; }
    public Account? To { get; set; }
    public int Code { get; set; }
    public TData Data { get; set; } = default!;
}

