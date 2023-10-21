using OOP.Classes;

/*
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

secondStudent = null;

if (firstStudent?.Name == "Kirill")
{
    Console.WriteLine("Это лучший препод на свете :)");
}

firstStudent.LastName ??= "Kislov";

firstStudent.LastName = secondStudent?.LastName ?? "Kislov";
*/

static string GetCheck(decimal value, string currency)
{

    var moneyWithCurrency = currency switch
    {
        "RUR" => value.RubleConverter(),
        "USD" => value.DollarConverter(),
        _ => throw new ArgumentException(nameof(currency))
    };
    return $"Ваш чек составил {value} {moneyWithCurrency}";
}


Console.WriteLine(GetCheck(150.5m, "RUR"));
Console.WriteLine(GetCheck(250.15m, "USD"));
Console.WriteLine(GetCheck(250.15m, "SOM"));

var rubs = 100.0m;

Console.WriteLine(rubs.RubleConverter());

