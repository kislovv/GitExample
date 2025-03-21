using System.Collections;

namespace LibraryIterator;

public class LibraryIterator : IIterator<Book>
{
    private int _current = 0;
    private Book[] _books;
    public LibraryIterator(Book[] books)
    {
        _books = books;
    }
    public Book CurrentItem
    {
        get
        {
            return _books[_current];
        }
        private set
        {
            _books[_current] = value;
        } 
    }

    public Book First
    {
        get
        {
            return _books[0];
        }
    }

    public bool IsDone
    {
        get
        {
            return _current == _books.Length;
        }
    }
    public void Next()
    {
        _current++;
    }
}