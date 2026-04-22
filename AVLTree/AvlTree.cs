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

        if (Root == null)
        {
            Root = addedNode;
            return;
        }
        
        AddInternal(addedNode, Root);
        
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

    private void AddInternal(AVLNode<T> insertNode, AVLNode<T>? currentNode)
    {
        if (currentNode == null)
        {
            currentNode = insertNode;
        }
        else
        {
            if (Comparer<T>.Default.Compare(
                    currentNode.Data, insertNode.Data) > 0)
            {
                AddInternal(insertNode, currentNode.Left);
            }

            if (Comparer<T>.Default.Compare(
                    currentNode.Data, insertNode.Data) < 0)
            {
                AddInternal(insertNode, currentNode.Right);
            }
        }
        //TODO: Balance
        if (currentNode.BalanceFactor is > 1 or < -1)
        {
            
        }
    }

    private void Balance(AVLNode<T> parentNode)
    {
        switch (parentNode.BalanceFactor)
        {
            case 2 when parentNode.Right!.BalanceFactor == 1:
                RightRotation(parentNode);
                break;
            case 2 when parentNode.Right.BalanceFactor == -1:
                parentNode.Right = RightRotation(parentNode);
                LeftRotation(parentNode);
                break;
            case -2 when parentNode.Left!.BalanceFactor == -1:
                LeftRotation(parentNode);
                break;
            case -2 when parentNode.Left.BalanceFactor == 1:
                parentNode.Left = LeftRotation(parentNode.Left);
                RightRotation(parentNode);
                break;
        }
    }

    private AVLNode<T> RightRotation(AVLNode<T> subTree)
    {
        var temp = subTree.Left;
        subTree.Left = temp!.Right;
        temp.Right = subTree;
        return temp;
    }
    
    private AVLNode<T> LeftRotation(AVLNode<T> subTree)
    {
        var newRoot = subTree.Right;
        subTree.Right = newRoot!.Left;
        newRoot.Left = subTree;
        return newRoot;
    }
}