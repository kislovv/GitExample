namespace ClassWork;

public class Exhibitor
{
    public string Name { get; set; }
    public string Breed { get; set; }


    public static explicit operator Exhibitor(Cat cat)
    {
        return new Exhibitor
        {
            Name = cat.Name,
            Breed = cat.Breed,
        };
    }
}