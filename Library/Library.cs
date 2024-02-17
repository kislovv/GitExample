namespace Library;

public class Library : IAggregator<Book> 
{
     private Book[] _items;

     public Library(Book[] books)
     {
          _items = books;
     }

     public Book this[int i]
     {
          get
          {
               return _items[i];
          }
           
     }

     public int Count
     {
          get
          {
               return _items.Length;
          }
     }
     public IIterator<Book> CreateIterator()
     {
          return new Librarian(this);
     }
}