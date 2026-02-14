namespace OOP.Classes;

public interface IRocket
{ 
    string Name { get; }
    int Power { get; }
    void Check();
    void Start();
    void Stop();
}