namespace SportFederation;

public interface ITeamManager<in T, in TV> 
    where T: Team<TV>
    where TV : Teammate
{
    bool RegisterTeam(T team);
    bool RegisterTeammate(TV teammate, T team);
}