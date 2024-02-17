namespace SportFederation;

public class Team<T> where T: Teammate
{
    public List<T> Teammates { get; set; }
    public string Name { get; set; }
    public int Quota { get; set; }
}