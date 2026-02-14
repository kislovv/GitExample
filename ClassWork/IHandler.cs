namespace ClassWork;

public interface IHandler<TRequest>
{
    public IHandler<TRequest>? Next { get; set; }
    
    void Handle(TRequest input);
}