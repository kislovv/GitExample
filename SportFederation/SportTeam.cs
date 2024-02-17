namespace SportFederation;

public class SportTeam : Team<SportTeammate>
{
    public int TeamWinCount { get; set; }
    public TypeOfSport TypeOfSport { get; set; }
}