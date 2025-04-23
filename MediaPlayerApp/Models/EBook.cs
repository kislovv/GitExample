namespace MediaPlayerApp.Models;

public class EBook: IMediaItem
{
    public required string Title { get; init; }
    public required TimeSpan Duration { get; init; }
    public List<string> Tags { get; } = [];
    public Dictionary<string, object> MetaData { get; } = [];
    public int PageCount { get; set; }
}