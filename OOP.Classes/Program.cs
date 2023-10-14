using OOP.Classes;

var firstStudent = new Student(26)
{
    Name = "Li",
    LastName = "Kislov",
    MidName = "Alexseevich"
};

Console.WriteLine(
    $"Меня зовут {firstStudent.Name}, мне {firstStudent.GetAge()} лет. Мой профиль обучения : {firstStudent.GetTypeOfStudying()}");

firstStudent.SetEndedAt(DateTimeOffset.Now.AddYears(6));

Console.WriteLine($"Я закончу обучение в {firstStudent.GetEndedAt().Year} году");


var secondStudent = new Student( 18, TypeOfStudying.University );

Console.WriteLine(
    $"Меня зовут {secondStudent.Name}, мне {secondStudent.GetAge()} лет. Мой профиль обучения : {secondStudent.GetTypeOfStudying()}");


var students = new Student[] {firstStudent, secondStudent};

var studentComparer = new StudentComparer();
Array.Sort(students, studentComparer);