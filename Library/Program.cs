
using Library;

var lib = new Library.Library(
    new Book[]
    {
        new Book(new DateOnly(2001, 7, 30), "oleg", "rpd1"),
        new Book(new DateOnly(1999, 8, 1), "oleg", "rpd2"),
        new Book(new DateOnly(2021, 5, 6), "oleg", "rpd3"),
        new Book(new DateOnly(2012, 11, 29), "oleg", "rpd4")
    });
var librarian = lib.CreateIterator();
var current = librarian.First;
while (!librarian.IsDone && current != null)
{
    Console.WriteLine(current.Name);
    current = librarian.CurrentItem;
}    