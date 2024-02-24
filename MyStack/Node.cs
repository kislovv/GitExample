namespace MyStack;

public class Node<TData>(TData data)
{
    public Node<TData>? Next { get; set; }
    public TData Data { get; set; } = data;
}