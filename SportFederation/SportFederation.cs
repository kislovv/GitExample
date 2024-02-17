namespace SportFederation;

public class SportFederation: IEventManager<SportEvent>, 
    ITeamManager<SportTeam,SportTeammate>
{
    public bool CloseEvent(SportEvent evt)
    {
        throw new NotImplementedException();
    }

    public bool RegisterEvent(SportEvent evt)
    {
        throw new NotImplementedException();
    }

    public bool StartEvent(SportEvent evt)
    {
        throw new NotImplementedException();
    }

    public bool RegisterTeam(SportTeam team)
    {
        throw new NotImplementedException();
    }

    public bool RegisterTeammate(SportTeammate teammate, SportTeam team)
    {
        throw new NotImplementedException();
    }
}