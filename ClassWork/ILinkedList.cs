using System.Collections.Generic;

namespace ClassWork;

public interface ILinkedList<T> : IEnumerable<T>
{
    void Add(T item);
    void Remove(T item);
    bool Contains(T item);
    void Clear();
}