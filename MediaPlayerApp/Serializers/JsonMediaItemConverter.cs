using System.Text.Json;
using System.Text.Json.Serialization;
using MediaPlayerApp.Models;

namespace MediaPlayerApp.Serializers;

public class JsonMediaItemConverter: JsonConverter<IMediaItem>
{
    public override IMediaItem? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var root = jsonDocument.RootElement;
        
        var extension = root.GetProperty("Title").GetString();

        return extension switch 
        {
            var ext when ext.Contains("mp3") => JsonSerializer.Deserialize<AudioTrack>(root.GetRawText(), options),
            var ext when ext.Contains("avi") => JsonSerializer.Deserialize<VideoClip>(root.GetRawText(), options),
            var ext when ext.Contains("fb2") => JsonSerializer.Deserialize<EBook>(root.GetRawText(), options),
            _ => throw new NotSupportedException("Unknown media type")
        };
    }

    public override void Write(Utf8JsonWriter writer, IMediaItem value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize<object>(writer, (object)value, options);
    }
}