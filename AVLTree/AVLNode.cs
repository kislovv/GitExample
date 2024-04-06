namespace AVLTree;

public class AVLNode<T>
{
    public AVLNode<T>? Parent { get; set; }
    public AVLNode<T>? Left { get; set; }
    public AVLNode<T>? Right { get; set; }
    public required T Data { get; set; }

    public int BalanceFactor => GetHeight(Right) - GetHeight(Left);

    public int Height
    {
        get
        {
            var hl = GetHeight(Left);
            var hr = GetHeight(Right);
            return (hl > hr ? hl : hr ) + 1;
        }
    }

    private static int GetHeight(AVLNode<T>? p)
    {
        return p?.Height ?? 0;
    }
}