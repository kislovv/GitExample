using System.Collections;
using System.Collections.Generic;

namespace ClassWork;

public class MyStack<T>:IMyStack<T>
{
    
    private Node<T>? _head;
    
    public IEnumerator<T> GetEnumerator()
    {
        if (IsEmpty)
        {
            yield break;
        }
        var node = _head;
        while (node != null)
        {
            yield return node.Data;
            node = node.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Push(T data)
    {
        var newNode = new Node<T>()
        {
            Data = data
        };
        if (IsEmpty)
        {
            _head = newNode;
            return;
        }
        
        newNode.Next = _head;
        _head = newNode;
    }

    public T Pop()
    {
        if (IsEmpty)
        {
            throw new System.InvalidOperationException("Stack is empty");
        }
        
        var node = _head;
        _head = _head!.Next;
        
        return node!.Data;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            throw new System.InvalidOperationException("Stack is empty");
        }

        return _head!.Data;
    }

    public bool IsEmpty
    {
        get
        {
            return _head == null;
        }
    }
}