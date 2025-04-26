using MediaPlayerApp.Models;

namespace MediaPlayerApp.Serializers;

public interface IMediaSerializer
{
    void Serialize(string path, List<IMediaItem> items);
    List<IMediaItem>? Deserialize(string path);
}