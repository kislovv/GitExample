﻿
using System.Threading.Channels;
using LINQExamples;

var listOfSchoolStudents = new List<SchoolStudent>()
{
    new SchoolStudent("Petya", 18, 11),
    new SchoolStudent("Masha", 17, 10),
    new SchoolStudent("Vasya", 18, 11),
    new SchoolStudent("Artur", 16, 9),
    new SchoolStudent("Leyla", 15, 8),
    new SchoolStudent("Joseph", 18, 11)
};

var groupedSchoolStudentsByAge = listOfSchoolStudents
    .GroupBy(s => s.Age)
    .ToDictionary(students => students.Key,
        students => students.ToList());


Func<SchoolStudent, bool> checkSchoolStudent = 
    (schoolStudent) => schoolStudent.Age >= 18;


var universityStudents = listOfSchoolStudents
    .Where(schoolStudent => schoolStudent.Age >= 18)
    .Select(s => new UniversityStudent
    {
        Age = s.Age,
        UniversityName = "K(P)FU",
        Name = s.Name,
        Cource = 1
    }).ToList();

listOfSchoolStudents.Add(new SchoolStudent("Abobus", 19, 12));

foreach (var student in universityStudents)
{
    Console.WriteLine(student.Name);
}



bool CheckAge(SchoolStudent schoolStudent)
{
    return schoolStudent.Age >= 18;
}

var list = new List<Action>();


/*for (int i = 0; i < 10; i++)
{
    var outI = i;
    list.Add(() => Console.WriteLine(outI));
}*/

int i = 0;
while (i < 10)
{
    //избавляемся от замыкания
    var outI = i;
    list.Add(() => Console.WriteLine(outI));
    i++;
}

foreach (var temp in list)
{
    temp();
}