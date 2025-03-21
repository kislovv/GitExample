using System.Collections;

namespace LibraryIterator;

public class LibraryAggregate : IAggregate<Book>
{
    private Book[] _items;
    public LibraryAggregate(Book[] items)
    {
        _items = items;
    }

    public IIterator<Book> CreateIterator()
    {
        return new LibraryIterator(_items);
    }
}