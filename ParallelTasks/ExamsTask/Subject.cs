namespace ParallelTasks.ExamsTask;

public class Subject
{
    public string Name { get; }
    public Teacher Teacher { get; }

    public Subject(string name, Teacher teacher)
    {
        Name = name;
        Teacher = teacher;
    }

    public override string ToString() => Name;
}