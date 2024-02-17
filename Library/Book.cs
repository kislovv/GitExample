namespace Library;

public class Book(DateOnly dateOfPublish, string author, string name)
{
    public string Name { get; } = name;
    public string Author { get; } = author;
    public DateOnly DateOfPublish { get; } = dateOfPublish;
}