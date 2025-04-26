using System.Text.Json;
using MediaPlayerApp.Models;

namespace MediaPlayerApp.Serializers;

public class JsonMediaSerializer: IMediaSerializer
{
    private readonly JsonMediaItemConverter _converter = new();
    public void Serialize(string path, List<IMediaItem> items)
    {
        throw new NotImplementedException();
    }

    public List<IMediaItem> Deserialize(string path)
    {
        return JsonSerializer.Deserialize<List<IMediaItem>>(path, new JsonSerializerOptions
        {
            Converters = { _converter }
        }) ?? [];
    }
}