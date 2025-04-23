namespace MediaPlayerApp.Data;

public interface IRepository<T>
{
    void Add(T item);
    List<T> GetAll();
    IEnumerable<T> Find(Func<T, bool> predicate);
}