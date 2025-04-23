namespace MediaPlayerApp.Models;

public class VideoClip : IMediaItem
{
    public required string Title { get; init; }
    public required TimeSpan Duration { get; init; }
    public List<string> Tags { get; } = [];
    public Dictionary<string, object> MetaData { get; } = [];
    public required string Resolution { get; init; }
}