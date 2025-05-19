namespace ParallelTasks.Singleton;

public class Computer(string name)
{
    private Os? _os;

    public void LaunchOs(string name)
    {
        _os = new Os(name);
        Console.WriteLine($"OS: {_os.Name}");
    }
}