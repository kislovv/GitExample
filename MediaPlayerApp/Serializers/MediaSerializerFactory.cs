namespace MediaPlayerApp.Serializers;

public class MediaSerializerFactory
{
    public static IMediaSerializer GetMediaSerializer(string path)
    {
        var extension = Path.GetExtension(path);
        if (extension == null)
        {
            throw new Exception("Extension could not be found.");
        }

        return extension switch
        {
            "json" => new JsonMediaSerializer(),
            "yaml" => new YamlMediaSerializer(),
            _ => throw new Exception("Extension could not be found.")
        };
    }
}