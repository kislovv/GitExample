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
        ExamStatuses.Add(subject, ExamStatus.Preparing);
        Console.WriteLine($"student {this.Id} is preparing for {subject.Name}");
        Thread.Sleep(4000);
    }

    public void TakeExam(Subject subject)
    {
        ExamStatuses[subject] = ExamStatus.Waiting;
        Console.WriteLine($"student {this.Id} is waiting for {subject.Name}");
        subject.Teacher.TakeExam(this, subject);
        ExamStatuses[subject] = ExamStatus.Completed;
        Console.WriteLine($"student {this.Id} is completed {subject.Name}");
    }
}