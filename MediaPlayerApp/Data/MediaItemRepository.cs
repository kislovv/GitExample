using MediaPlayerApp.Models;

namespace MediaPlayerApp.Data;

public class MediaItemRepository : IRepository<IMediaItem>
{
    public void Add(IMediaItem item)
    {
        throw new NotImplementedException();
    }

    public List<IMediaItem> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMediaItem> Find(Func<IMediaItem, bool> predicate)
    {
        throw new NotImplementedException();
    }
}