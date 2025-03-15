namespace ChainOfResponsibility;

public interface IHandler<in T>
{
    IHandler<T>? Succeser { get; }
    void Handle(T element);
}