using AVLTree;

public class AvlTree<T>
{
    public AVLNode<T>? Root { get; private set; }

    public void Add(T data)
    {
        Root = Add(Root, data);
    }

    public void Remove(T data)
    {
        Root = Remove(Root, data);
    }

    public bool Contains(T data)
    {
        return Contains(Root, data);
    }

    public List<T> InOrder()
    {
        var result = new List<T>();
        InOrder(Root, result);
        return result;
    }

    private AVLNode<T> Add(AVLNode<T>? node, T data)
    {
        if (node == null)
        {
            return new AVLNode<T>
            {
                Data = data
            };
        }

        int compareResult = Comparer<T>.Default.Compare(data, node.Data);

        if (compareResult < 0)
        {
            node.Left = Add(node.Left, data);
        }
        else if (compareResult > 0)
        {
            node.Right = Add(node.Right, data);
        }
        else
        {
            return node;
        }

        UpdateHeight(node);
        return Balance(node);
    }

    private AVLNode<T>? Remove(AVLNode<T>? node, T data)
    {
        if (node == null)
            return null;

        int compareResult = Comparer<T>.Default.Compare(data, node.Data);

        if (compareResult < 0)
        {
            node.Left = Remove(node.Left, data);
        }
        else if (compareResult > 0)
        {
            node.Right = Remove(node.Right, data);
        }
        else
        {
            switch (node.Left)
            {
                // 1. Нет детей
                case null when node.Right == null:
                    return null;
                // 2. Только правый ребенок
                case null:
                    return node.Right;
            }

            // 3. Только левый ребенок
            if (node.Right == null)
            {
                return node.Left;
            }

            // 4. Два ребенка
            var minNode = FindMin(node.Right);
            node.Data = minNode.Data;
            node.Right = Remove(node.Right, minNode.Data);
        }

        UpdateHeight(node);
        return Balance(node);
    }

    private bool Contains(AVLNode<T>? node, T data)
    {
        if (node == null)
            return false;

        var compareResult = Comparer<T>.Default.Compare(data, node.Data);

        return compareResult switch
        {
            0 => true,
            < 0 => Contains(node.Left, data),
            _ => Contains(node.Right, data)
        };
    }

    private void InOrder(AVLNode<T>? node, List<T> result)
    {
        if (node == null)
            return;

        InOrder(node.Left, result);
        result.Add(node.Data);
        InOrder(node.Right, result);
    }

    private AVLNode<T> FindMin(AVLNode<T> node)
    {
        return node.Left == null ? node : FindMin(node.Left);
    }

    private int GetHeight(AVLNode<T>? node)
    {
        return node?.Height ?? 0;
    }

    private void UpdateHeight(AVLNode<T> node)
    {
        var leftHeight = GetHeight(node.Left);
        var rightHeight = GetHeight(node.Right);
        node.Height = Math.Max(leftHeight, rightHeight) + 1;
    }

    private int GetBalanceFactor(AVLNode<T>? node)
    {
        if (node == null)
            return 0;

        return GetHeight(node.Right) - GetHeight(node.Left);
    }

    private AVLNode<T> Balance(AVLNode<T> node)
    {
        var balanceFactor = GetBalanceFactor(node);

        switch (balanceFactor)
        {
            // Перевес вправо
            case 2:
            {
                if (GetBalanceFactor(node.Right) < 0)
                {
                    node.Right = RotateRight(node.Right!);
                }

                return RotateLeft(node);
            }
            // Перевес влево
            case -2:
            {
                if (GetBalanceFactor(node.Left) > 0)
                {
                    node.Left = RotateLeft(node.Left!);
                }

                return RotateRight(node);
            }
            default:
                return node;
        }
    }

    private AVLNode<T> RotateLeft(AVLNode<T> node)
    {
        var newRoot = node.Right!;
        var movedSubTree = newRoot.Left;

        newRoot.Left = node;
        node.Right = movedSubTree;

        UpdateHeight(node);
        UpdateHeight(newRoot);

        return newRoot;
    }

    private AVLNode<T> RotateRight(AVLNode<T> node)
    {
        var newRoot = node.Left!;
        var movedSubTree = newRoot.Right;

        newRoot.Right = node;
        node.Left = movedSubTree;

        UpdateHeight(node);
        UpdateHeight(newRoot);

        return newRoot;
    }
}