namespace ParallelTasks.ExamsTask;

public class Teacher
{
    private SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
    public string Name { get; }

    public Teacher(string name)
    {
        Name = name;
    }

    public void TakeExam(Student student, Subject subject)
    {
        _semaphore.Wait();
        student.ExamStatuses[subject] = ExamStatus.InProgress;
        Console.WriteLine($"student {student.Id} is taking exam {subject.Name}");
        Thread.Sleep(3000);
        _semaphore.Release();
    }
}