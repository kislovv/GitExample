namespace MediaPlayerApp.Models;

public class PlayList
{
    public required string Name { get; set;}
    public List<IMediaItem> MediaItems { get; } = [];
}