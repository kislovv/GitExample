namespace LibraryIterator;

public interface IIterator<T>
{
    T CurrentItem { get; }
    T First { get; }
    bool IsDone { get; }
    void Next();
}