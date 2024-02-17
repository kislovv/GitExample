namespace SportFederation;

public class Event
{
    public DateTimeOffset StartedAt { get; set; }
    public DateTimeOffset EndedAt { get; set; }
    public string Place { get; set; }
    public string Name { get; set; }
}