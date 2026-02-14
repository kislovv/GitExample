namespace OOP.Classes;

public class Souz : Rocket
{
    public Souz() : base("Союз", 800)
    {
    }

    public override void Check()
    {
        Console.WriteLine("Проверка систем...");
    }

    public override void Start()
    {
        Console.WriteLine("Запуск...");
    }

    public override void Stop()
    {
        Console.WriteLine("Остановка...");
    }
}