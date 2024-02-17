using System.Collections;

namespace MyLinkedList;

public class MyLinkedList<T> : ILinkedList<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public MyLinkedList(T head)
    {
        _head = new Node<T>(head);
        _tail = _head;
        Count = 1;
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T data)
    {
        var node = new Node<T>(data);
        if (IsEmpty)
        {
            _head = node;
            _tail = _head;
        }
        else
        {
            _tail!.Next = node;
            _tail = node;
        }
        
        Count++;
    }

    public bool Remove(T data)
    {
        if (IsEmpty)
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
        
        var index = 2;
        var currentNode = _head.Next;
        var prev = _head;
        
        while (index <= Count)
        {
            if (!currentNode.Data!.Equals(data))
            {
                prev = currentNode;
                currentNode = currentNode.Next;
                index++;
            }
            else if (currentNode.Equals(_tail))
            {
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

    public int Count { get; private set; }
    public bool IsEmpty
    {
        get
        {
            return Count == 0;
        }
    }
    public void Clear()
    {
        _head = null;
        _tail = null;
        Count = 0;
    }

    public bool Contains(T data)
    {
        if (IsEmpty)
        {
            return false;
        }
        
        var index = 1;
        var currentNode = _head;
        while (index <= Count)
        {
            if (currentNode!.Data!.Equals(data))
            {
                return true;
            }

            currentNode = currentNode.Next;
            index++;
        }
        return false;
    }

    public void AppendFirst(T data)
    {
        var node = new Node<T>(data);
        if (IsEmpty)
        {
            _head = node;
            _tail = _head;
        }
        else
        {
            node.Next = _head!;
            _head = node;
        }

        Count++;
    }
}