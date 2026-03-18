namespace AVLTree;

public class AVLNode<T>
{
    public required T Data { get; set; }
    public AVLNode<T>? Left { get; set; }
    public AVLNode<T>? Right { get; set; }
    public int Height { get; set; } = 1;
}