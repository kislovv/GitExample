namespace MediaPlayerApp.Models;

public class AudioTrack: IMediaItem
{
    public required string Title { get; init; }
    public required TimeSpan Duration { get; init; }
    public List<string> Tags { get; } = [];
    public Dictionary<string, object> MetaData { get; } = [];
    public int BitRate { get; set; }
}