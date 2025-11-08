namespace OOP.Classes;

public interface IHuman:  IEatable,  ISleapable
{
    string FullName { get; }
    int Age { get;}
    string Gender { get; init; }
}