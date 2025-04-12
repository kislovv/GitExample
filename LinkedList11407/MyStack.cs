using System.Collections;

namespace LinkedList11407;

public class MyStack<T> : IMyStack<T>
{
    private Node<T>? _head;

    public MyStack(T head)
    {
        _head = new Node<T>()
        {
            Data=head
        };
    }
    public IEnumerator<T> GetEnumerator()
    {
        var current = _head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Push(T item)
    {
        _head ??= new Node<T>()
        {
            Data = item
        };
    }

    public T Pop()
    {
        var head = _head;
        if (_head!.Data != null)
        { 
            _head = null;
        } 
        return head!.Data;
    }

    public T Peek()
    {
        return _head!.Data;
    }
}