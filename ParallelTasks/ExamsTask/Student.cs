namespace ParallelTasks.ExamsTask;

public class Student
{
    public int Id { get; }
    public Dictionary<Subject, ExamStatus> ExamStatuses { get; } = new();

    public Student(int id)
    {
        Id = id;
    }

    public void PrepareForSubject(Subject subject)
    {
        //TODO: Сделать метод
    }

    public void TakeExam(Subject subject)
    {
        //TODO: Сделать метод
    }
}