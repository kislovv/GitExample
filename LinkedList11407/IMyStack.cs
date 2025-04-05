namespace LinkedList11407;

public interface IMyStack<T> : IEnumerable<T>
{
    void Push(T item);
    T Pop();
    T Peek();
}