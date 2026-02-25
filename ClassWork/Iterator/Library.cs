using System.Collections;
using System.Collections.Generic;

namespace ClassWork.Iterator;

public class Library : IEnumerable<Book>
{
    private Book[] _books;

    public string SearchingGenre { get; set; } = "Comics";

    public Library(Book[] books)
    {
        _books = books;
    }

    public IEnumerator<Book> GetEnumerator()
    {
        for (int i = 0; i < _books.Length; i++)
        {
            if (_books[i].Genre == SearchingGenre)
            {
                yield return _books[i];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}