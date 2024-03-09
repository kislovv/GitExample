namespace AdapterExample;

public class Auto : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Машина др-др-др-др!");
    }
}