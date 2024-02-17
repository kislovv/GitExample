namespace Library;

public class Librarian : IIterator<Book>
{
    private Library _aggregate;
    private int _current;

    public Librarian(Library aggregate)
    {
        _aggregate = aggregate;
    }

    public Book CurrentItem
    {
        get
        {
            return _aggregate[_current];
        }
    }

    public Book First
    {
        get
        {
            return _aggregate[0];
        }
    }

    public bool IsDone
    {
        get
        {
            return (_current >= _aggregate.Count);
        }
    }
    public void Next()
    {
        if (_current + 1 >= _aggregate.Count)
        {
            _current = 0;
        }
        _current++;
    }
}