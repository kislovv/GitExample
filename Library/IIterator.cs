namespace Library;

public interface IIterator<out T>
{
    T CurrentItem { get; }
    T First { get; }
    bool IsDone { get; }
    void Next();
}