namespace AdapterExample;

public class TransportToAnimalAdapter : ITransport
{
    private IAnimal _animal;

    public TransportToAnimalAdapter(IAnimal animal)
    {
        _animal = animal;
    }

    public void Drive()
    {
        _animal.Move();
    }
}