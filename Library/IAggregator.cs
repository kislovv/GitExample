namespace Library;

public interface IAggregator<out T>
{
    IIterator<T> CreateIterator();
}