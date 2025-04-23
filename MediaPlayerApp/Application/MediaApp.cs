using MediaPlayerApp.Data;
using MediaPlayerApp.Models;

namespace MediaPlayerApp.Application;

public class MediaApp
{
    private MediaPlayer _player = new MediaPlayer(new MediaItemRepository());


    public void PlayItem(string name)
    {
        throw new NotImplementedException();
    }

    List<IMediaItem> ImportFromZip(string zipPath)
    {
        throw new NotImplementedException();
    }

    void ShowHistory()
    {
        throw new NotImplementedException();
    }
}