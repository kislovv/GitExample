using System.Collections;

namespace LibraryIterator;

public class LibraryIteratorV2 : IEnumerator<Book>
{
    private int _current = -1;
    private Book[]? _books;

    public LibraryIteratorV2(Book[] books)
    {
        _books = books;
    }
    
    public bool MoveNext()
    {
        if (_current == _books!.Length-1)
        {
            return false;
        }
        _current++;
        return true;
    }

    public void Reset()
    {
        _current = 0;
    }

    public Book Current => _books![_current];

    object? IEnumerator.Current => Current;

    public void Dispose()
    {
        _books = null;
    }
}