using System.Collections;
using System.Collections.Generic;

namespace ClassWork.Iterator;

public class Librarian : IEnumerator<Book>
{
    private Book[] _books;
    private string _genre;
    private int _index = -1;
    
    public Librarian(Book[] books, string genre)
    {
        _books = books;
        _genre = genre;
    }
    
    public bool MoveNext()
    {
        _index++;
        
        while (_index < _books.Length)
        {
            if (_books[_index].Genre == _genre)
            {
                return true;
            }
            
            _index++;
        }
        
        return false;
    }

    public Book Current
    {
        get
        {
            return _books[_index];
        }
    }
    public void Reset()
    {
        _index = -1;
    }

    object? IEnumerator.Current => Current;

    public void Dispose()
    {
        // TODO release managed resources here
    }
}