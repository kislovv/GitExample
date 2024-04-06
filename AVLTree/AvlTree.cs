namespace AVLTree;

public class AvlTree<T>(T data)
{
    public AVLNode<T> Root { get; set; } = new()
    {
        Data = data
    };
    
    public void Add(T Data)
    {
        var addedNode = new AVLNode<T>
        {
            Data = data
        };
        var current = Root;
        while (true)
        {
            if (Comparer<T>.Default.Compare(
                    current.Data, addedNode.Data) > 0)
            {
                if (current.Left != null)
                {
                    current = current.Left;
                }
                else
                {
                    current.Left = addedNode;
                    //TODO: Balance
                    break;
                }
            }
            else
            {
                if (current.Right != null)
                {
                    current = current.Right;
                }
                else
                {
                    current.Right = addedNode;
                    //TODO: Balance
                    break;
                }
            }
        }
    }

    private void Balance()
    {
        
    }

    private void RightRotation(AVLNode<T> subTree)
    {
        
    }
    
}