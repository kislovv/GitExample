namespace ClassWork;

public class People
{
    public string Name { get; set; }


    public static Family<People> operator +(People p1, People p2)
    {
        return new Family<People>
        {
            Husband = p1,
            Wife = p2,
        };
    }
}