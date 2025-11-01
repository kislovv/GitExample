using OOP.Classes;

Console.WriteLine("Hello");

Student student = new Student("Жиляев Айдамир Хазретович", 18)
{
    TypeOfStudy = TypeOfStudy.University
};

student.Study();

Console.WriteLine($"{student.FullName} {student.Age} {student.TypeOfStudy} {student.LevelOfKnowledge}");
