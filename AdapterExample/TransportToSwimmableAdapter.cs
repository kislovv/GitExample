namespace AdapterExample;

public class TransportToSwimmableAdapter : ITransport
{
    private ISwimmable _swimmable;

    public TransportToSwimmableAdapter(ISwimmable swimmable)
    {
        _swimmable = swimmable;
    }
    
    public void Drive()
    {
        _swimmable.Swim();
    }
}