namespace ClassWork;

public class HandlerBuilder<T>
{
    private readonly IHandler<T> _root;
    private IHandler<T> _current;

    public HandlerBuilder(IHandler<T> handler)
    {
        _root = handler;
        _current = _root;
    }

    public void AddHandler(IHandler<T> handler)
    {
        _current.Next = handler;
        _current = handler;
    }

    public IHandler<T> Build()
    {
        return _root;
    }
}