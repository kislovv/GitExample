namespace ChainOfResponsibility;

public class BaseHandler<T> : IHandler<T>
{
    public BaseHandler(IHandler<T>? succeser)
    {
        Succeser = succeser;
    }

    public IHandler<T>? Succeser { get; }
    public virtual void Handle(T element)
    {
        Succeser?.Handle(element);
    }
}