namespace MediaPlayerApp.Models;

public interface IMediaItem
{
    public string Title { get;}
    public TimeSpan Duration { get; }
    public List<string> Tags { get; }
    public Dictionary<string, object> MetaData { get; }
}