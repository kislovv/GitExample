namespace OOP.Classes;

public class FalconS : Rocket
{
    public FalconS() : base("FalconS", 1500)
    {
    }

    public override void Check()
    {
        Console.WriteLine("Checking system...");
    }

    public override void Start()
    {
        Console.WriteLine("Starting...");
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping...");
    }

    public void GetFreeWifi()
    {
        Console.WriteLine("Getting free wifi...");
    }
}