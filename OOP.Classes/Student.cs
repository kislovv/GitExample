namespace OOP.Classes;

public class Student : Human
{
    public TypeOfStudy TypeOfStudy { get; init; }
    public int LevelOfKnowledge { get; private set; }

    public Student(string fullName, int age): base(fullName, age)
    {
        LevelOfKnowledge = 50;
        TypeOfStudy = TypeOfStudy.University;
    }
    
    public Student(string fullName, int age,
        TypeOfStudy typeOfStudy): this(fullName, age)
    {
        TypeOfStudy = typeOfStudy;
    }

    public void Study()
    {
        Random rand = new Random();
        LevelOfKnowledge = rand.Next(1, 100);
    }

    public void PassExam()
    {
        if (LevelOfKnowledge < 56)
        {
            Console.WriteLine("Not today!");
            return;
        }

        Age++;
    }

    public override void Eat()
    {
        Console.WriteLine($"{FullName} as student eating in shawerma:) ");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{FullName} as student sleeping in dorm");
    }

    public override string ToString()
    {
        return $"Name: {FullName}\nAge: {Age}\nStudy in: {TypeOfStudy}\nLevel: {LevelOfKnowledge}";
    }
}