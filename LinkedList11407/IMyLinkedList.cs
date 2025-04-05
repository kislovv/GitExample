namespace LinkedList11407;

public interface IMyLinkedList<T> : IEnumerable<T>
{
    void Add(T data);
    bool Remove(T data);
    int Count { get; }
    bool IsEmpty { get; }
    void Clear();
    bool Contains(T data);
    void AppendFirst(T data);
}