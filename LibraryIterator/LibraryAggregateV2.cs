using System.Collections;

namespace LibraryIterator;

public class LibraryAggregateV2 : IEnumerable<Book>
{
    private Book[] _items;
    
    public LibraryAggregateV2(Book[] books)
    {
        _items = books;
    }
    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIteratorV2(_items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new LibraryIteratorV2(_items);
    }
}