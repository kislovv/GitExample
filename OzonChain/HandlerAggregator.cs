namespace OzonChain;

public class HandlerAggregator<T>(IHandler<T> startedHandler)
{
    private IHandler<T> StartedHandler { get; } = startedHandler;
    private IHandler<T> LastHandler { get; set; } = startedHandler;

    public bool AddHandler(IHandler<T> lastHandler)
    {
        LastHandler.Successor = lastHandler;
        LastHandler = lastHandler;
        
        return true;
    }

    public T StartChain(T element)
    {
        return StartedHandler.Handle(element);
    }
}