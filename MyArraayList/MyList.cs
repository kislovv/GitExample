using System.Collections;
using System.Security.Cryptography;

namespace MyArraayList;

public class MyList<T> : IMyList<T>
{
    private T?[] _array;
    private int _size;
    private int _count;
    private const int _defaultCapacity = 4;
    
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            return _array[index];
        }
        set
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            _array[index] = value;
        }
    }

    public MyList(int size = _defaultCapacity)
    {
        
        _size = size;
        _array = new T[size];
        _count = 0;
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _array[i]!;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count 
    {
        get
        {
            return _count;
        }
    }
    public bool Contains(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i]?.Equals(item) ?? false)
            {
                return true;
            }
        }
        return false;
    }

    public void Add(T item)
    {
        if (_count == _array.Length - 1)
        {
            _array = Resize();
        }
        _array[_count++] = item;
        
    }

    public void Remove(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i]?.Equals(item) ?? false)
            {
                if (i != _count - 1)
                {
                    for (int j = i; j < _count - 1; j++)
                    {
                        _array[j] = _array[j + 1];
                    }
                }
                _array[_count - 1] = default(T);
                _count--;
            }
        }
    }

    public void Clear()
    {
        _array = new T[_defaultCapacity];
        _count = 0;
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i]?.Equals(item) ?? false)
            {
                return i;
            }
        }
        return -1;
    }

    public void Reverse()
    {
        for (int i = 0; i < _count / 2; i++)
        {
            (_array[i], _array[_count - 1 - i]) = (_array[_count - 1 - i], _array[i]);
        }
    }

    private T[] Resize()
    {
        T[] newArray = new T[_array.Length * 2];
        Array.Copy(_array, 0, newArray, 0, _array.Length);
        return newArray;
    }
}