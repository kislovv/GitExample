namespace ClassWork;

public class PeopleManager
{
    private readonly People _people;
    private readonly string _company;
    public PeopleManager(People people, string company)
    {
        _people = people;
        _company = company;
    }

    public void ChangeName(string name)
    {
        _people.Name = name;
    }
}