using System.Collections.Generic;

namespace ClassWork;

public interface IMyStack<T>: IEnumerable<T>
{
    void Push(T data);
    T Pop();
    T Peek();
    bool IsEmpty { get; }
}