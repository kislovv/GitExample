namespace BinaryTree;

public class TreeNode<T>(T data)
{
    public TreeNode<T>? Left { get; set; }
    public TreeNode<T>? Right { get; set; }
    public T Data { get; set; } = data;
    public int Height { get; set; } = 0;
}