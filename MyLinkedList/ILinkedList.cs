namespace MyLinkedList;

public interface ILinkedList<T> : IEnumerable<T>
{
    void Add(T data);
    bool Remove(T data);
    int Count { get; }
    bool IsEmpty { get; }
    void Clear();
    bool Contains(T data);
    void AppendFirst(T data);
}
