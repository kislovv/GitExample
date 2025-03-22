namespace MyArraayList;

public interface IMyList<T> : IEnumerable<T>
{
    int Count { get; }
    bool Contains(T item);
    void Add(T item);
    void Remove(T item);
    void Clear();
    int IndexOf(T item);
    void Reverse();
}