namespace OzonChain;

public interface IHandler<T>
{
    IHandler<T>? Successor { get; set; }
    T Handle(T element);
}