namespace AdapterExample;

public class Driver
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}