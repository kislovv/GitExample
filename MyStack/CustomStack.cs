using System.Collections;
using System.Data;

namespace MyStack;

public class CustomStack<TData>(Node<TData>? head) : INodeStack<TData>
{
    public IEnumerator<TData> GetEnumerator()
    {
        var node = head;
        while (node != null)
        {
            yield return Pop();
            node = head;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count { get; private set; }
    public bool IsEmpty
    {
        get
        {
            return Count == 0;
        }
    }
    public void Push(TData item)
    {
        if (IsEmpty)
        {
            head = new Node<TData>(item);
            return;
        }

        var node = new Node<TData>(item)
        {
            Next = head
        };
        head = node;
        
        Count++;
    }

    public TData Pop()
    {
        if (IsEmpty)
        {
            throw new DataException("Stack is Empty");
        }

        var resultData = head!.Data;
        head = head.Next;
        Count--;
        
        return resultData;
    }

    public TData Peek()
    {
        if (IsEmpty)
        {
            throw new DataException("Stack is Empty");
        }

        return head!.Data;
    }
}