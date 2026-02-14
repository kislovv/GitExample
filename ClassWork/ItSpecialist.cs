namespace ClassWork;

public class ItSpecialist : Employee
{
    public string Grade {
        get
        {
            return Exp switch
            {
                < 3 => "Junior",
                < 7 => "Middle",
                _ => "Senior"
            };
        }
    }
}