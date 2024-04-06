namespace ParallelTasks.Singleton;

public class Os(string name)
{
    private Lazy<Os> _os = new (() => new Os(name));
    
    public string Name { get; set; } = name;
}