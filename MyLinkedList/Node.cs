namespace MyLinkedList;

public class Node<TData>
{
    public Node(TData data)
    {
        Data = data;
    }

    public Node<TData> Next { get; set; }
    public TData Data { get; set; }    
}