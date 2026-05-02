namespace ClassWork;

public record TaskItem(string Description, TaskPriority Priority, bool IsCompleted);

public enum TaskPriority
{
    Low,
    Normal,
    High,
}