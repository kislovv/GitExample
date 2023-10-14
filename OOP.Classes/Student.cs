using System.Reflection;
using System.Xml.Linq;

namespace OOP.Classes;

public class Student : IComparable
{
    private string _name;
    public string? Name
    {
        get
        {
            return _name;
        }
        init
        {
            if (_name == null || _name.Length < 3)
            {
                throw new ArgumentException(nameof(_name));
            }
            _name = value;
        }
        
    }

    public string LastName { get; set; }
    public string MidName { get; init; }
    private int age;
    private TypeOfStudying typeOfStudying;
    private DateTimeOffset startedAt;
    private DateTimeOffset endedAt;

    public Student(int age)
    {
        this.age = age;
        typeOfStudying = TypeOfStudying.University;
        startedAt = DateTimeOffset.Now;
        endedAt = DateTimeOffset.Now.AddYears(4);
    }

    public Student(int age,
        TypeOfStudying typeOfStudying) : this(age)
    {
        this.typeOfStudying = typeOfStudying;
    }
    
    public int GetAge()
    {
        return age;
    }

    public TypeOfStudying GetTypeOfStudying()
    {
        return typeOfStudying;
    }

    public DateTimeOffset GetEndedAt()
    {
        return endedAt;
    }

    public void SetEndedAt(DateTimeOffset endedAt)
    {
        this.endedAt = endedAt;
    }

    public int CompareTo(object? obj)
    {
        if(obj is not Student student)
        {
            throw new ArgumentException();
        }
        if(student.age > this.age)
        {
            return 1;
        }
        if(student.age < this.age)
        {
            return -1;
        }
        return 0;
    }
}