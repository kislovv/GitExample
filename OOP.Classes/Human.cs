namespace OOP.Classes;

public abstract class Human :  IHuman
{
    public string FullName { get; private set; }
    public int Age { get; protected set; }
    public string Gender { get; init; } = "Male"; 
    
    public Human(string fullName, int age)
    {
        FullName = fullName;
        Age = age;
    }

    public void Sleep()
    {
        Console.WriteLine("Human Sleeping...");
    }

    public abstract void Eat();
}