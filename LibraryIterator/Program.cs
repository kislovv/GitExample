namespace LibraryIterator;

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[3];
        books[0] = new Book() {Title = "Professional C# 6", Author = "Steve Jobs", Year = 2020};
        books[1] = new Book() {Title = "1984", Author = "Oruell", Year = 1949};
        books[2] = new Book() {Title = "Kashtanka", Author = "Chehov", Year = 1960};
        
        LibraryAggregate aggregate = new LibraryAggregate(books);
        IIterator<Book> iterator = aggregate.CreateIterator();
        Book i = iterator.First;
        while (!iterator.IsDone)
        {
            i = iterator.CurrentItem;
            Console.WriteLine($"{i.Title} {i.Author} {i.Year}");
            iterator.Next();
        }
    }
}