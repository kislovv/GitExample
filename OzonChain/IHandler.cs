namespace OzonChain;

public interface IHandler<T>
{
    IHandler<T>? Successor { get; }
    T Handle(T element);
}