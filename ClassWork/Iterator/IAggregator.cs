namespace ClassWork.Iterator;

public interface IAggregator<out T>
{
    IIterator<T> CreateIterator();
}