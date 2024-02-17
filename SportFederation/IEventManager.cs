namespace SportFederation;

public interface IEventManager<in T> where T: Event
{
    bool CloseEvent(T evt);
    bool RegisterEvent(T evt);
    bool StartEvent(T evt);
}