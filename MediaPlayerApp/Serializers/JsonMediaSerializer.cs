using MediaPlayerApp.Models;

namespace MediaPlayerApp.Serializers;

public class JsonMediaSerializer: IMediaSerializer
{
    public void Serialize(string path, List<IMediaItem> items)
    {
        throw new NotImplementedException();
    }

    public List<IMediaItem> Deserialize(string path)
    {
        throw new NotImplementedException();
    }
}