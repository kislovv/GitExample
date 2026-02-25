using System.Collections;
using System.Collections.Generic;

namespace ClassWork;

public class MyLinkedList<T> : ILinkedList<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public IEnumerator<T> GetEnumerator()
    {
        if (_head == null)
        {
            yield break;
        }
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

    public void Add(T item)
    {
        var node = new Node<T>()
        {
            Data = item
        };
        
        if (_head == null)
        {
            _head = node;
            _tail = node;
            return;
        }
        
        _tail!.Next = node;
        _tail = node;
    }

    public void Remove(T item)
    {
        if (_head == null)
        {
            _head = _tail;
            return;
        }

        if (_head == _tail)
        {
            if (Comparer.Default.Compare(item, _head.Data) == 0)
            {
                Clear();
            }
            return;
        }
        
        var previous = _head;
        var current = previous.Next;
        while (current != null)
        {
            if (Comparer.Default.Compare(current.Data, item) == 0)
            {
                if (current == _tail)
                {
                    previous.Next = null;
                    _tail = previous;
                    return;
                }
                
                previous.Next = current.Next;
                current.Next = null;
                return;
            }
            previous = current;
            current = previous.Next;
        }
    }

    public bool Contains(T item)
    {
        if (_head == null)
        {
            return false;
        }
        var current =  _head;

        while (current != null)
        {
            if (Comparer.Default.Compare(current.Data, item) == 0 || current.Data!.Equals(item))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void Clear()
    {
        _head = null;
        _tail = null;
    }
}