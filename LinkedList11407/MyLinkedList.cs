using System.Collections;

namespace LinkedList11407;

public class MyLinkedList<T>: IMyLinkedList<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public MyLinkedList(T head)
    {
        _head = new Node<T>() { Data = head };
        _tail = _head;
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

    public void Add(T data)
    {
        var node = new Node<T>
        {
            Data = data,
        };

        if (_head == null)
        {
            _head = node;
            _tail = node;
            return; 
        }
        
        _tail!.Next = node;
        _tail = node;
        Count++;
    }

    public bool Remove(T data)
    {
        if (IsEmpty || Count == 1 && !_head!.Data!.Equals(data))
        {
            return false;
        }
        if (Count == 1 && _head!.Data!.Equals(data))
        {
            Clear();
            return true;
        }
        if (_head!.Data!.Equals(data))
        {
            _head = _head.Next;
            Count--;
            return true;
        }
        
        var currentNode = _head.Next;
        var prev = _head;
        
        while (currentNode != null)
        {
            if (!currentNode.Data!.Equals(data))
            {
                prev = currentNode;
                currentNode = currentNode.Next;
            }
            else if (currentNode.Equals(_tail))
            {
                prev.Next = null;
                _tail = prev;
                Count--;
                
                return true;
            }
            else
            {
                prev.Next = currentNode.Next;
                Count--;
                return true;
            }
        }

        return false;
    }

    public int Count { get; private set; } = 1;

    public bool IsEmpty => Count == 0;

    public void Clear()
    {
        _head = null;
        _tail = null;
        Count = 0;
    }

    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void AppendFirst(T data)
    {
        
        var node = new Node<T>{ Data = data, Next = _head};
        
        if (_head == null)
        {
            _head = node;
            _tail = node;
            return; 
        }
       
        _head = node;
    }
}