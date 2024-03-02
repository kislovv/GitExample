namespace LINQExamples;

public class SchoolStudent(string name, byte age, int @class)
{
    public int Class { get; set; } = @class;
    public string Name { get; set; } = name;
    public byte Age { get; set; } = age;
}