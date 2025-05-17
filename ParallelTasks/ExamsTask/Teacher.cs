namespace ParallelTasks.ExamsTask;

public class Teacher
{
    public string Name { get; }
    /*spoiler
    private readonly SemaphoreSlim _lock = new(1, 1);
    */
    public Teacher(string name)
    {
        Name = name;
    }

    public void TakeExam(Student student, Subject subject)
    {
        //TODO: Сделать метод
    }
}