namespace OOP.Classes;

public class Student
{
    public string FullName { get; private set; }
    public int Age { get; private set; }
    public TypeOfStudy TypeOfStudy { get; init; }
    public int LevelOfKnowledge { get; private set; }

    public Student(string fullName, int age)
    {
        FullName = fullName;
        Age = age;
    }
    
    public Student(string fullName, int age, TypeOfStudy typeOfStudy)
    {
        FullName = fullName;
        Age = age;
        TypeOfStudy = typeOfStudy;
    }

    public void Study()
    {
        Random rand = new Random();
        LevelOfKnowledge = rand.Next(1, 100);
    }
}