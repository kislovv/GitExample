using OOP.Classes;

Student student = new Student("Жиляев Айдамир Хазретович", 18)
{
    TypeOfStudy = TypeOfStudy.University,
};
Student secondStudent = new Student("Кислов Кирилл Алексеевич", 28)
{
    TypeOfStudy = TypeOfStudy.University,
};
Student thirdStudent = new Student("Аткнин Алексей Александрович", 18)
{
    TypeOfStudy = TypeOfStudy.University,
};

student.Study();
student.Study();
student.Study();


secondStudent.Study();
secondStudent.Study();
secondStudent.Study();

thirdStudent.Study();
thirdStudent.Study();
thirdStudent.Study();


Student[]  students = [student,  secondStudent, thirdStudent];

Array.Sort(students, new  StudentComparer());


foreach (Student currentStudent in students)
{
    Console.WriteLine(currentStudent);
}

var game = new Game(Genre.Pony)
{
    Name = "My little Pony"
};


//student.Sleep();

//Console.WriteLine(student);
