namespace OOP.Classes;

public class RocketStation
{
    public static void Start(IRocket rocket)
    {
        Console.WriteLine($"Производится запуск ракеты {rocket.Name} с мощностью {rocket.Power}");
        rocket.Check();
        
        if (rocket.Power < 1000)
        {
            rocket.Stop();
        }
        else
        {
            rocket.Start();
        }

        Console.WriteLine($"Запуск ракеты {rocket.Name} завершен");
    }


    public static void Start(params IRocket[] rockets)
    {
        foreach (var rocket in rockets)
        {
            Start(rocket);
        }
    }
}