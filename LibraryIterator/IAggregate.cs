namespace LibraryIterator;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}