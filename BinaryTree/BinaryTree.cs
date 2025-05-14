namespace BinaryTree;

public class BinaryTree<T>(T rootData) where T : IComparable<T>
{
    private TreeNode<T>? _root = new(rootData);

    public void Add(T data)
    {
        if (_root == null)
        {
            _root = new TreeNode<T>(data);
        }
        
        Add(_root, data);
    }
    
    private TreeNode<T> Add(TreeNode<T>? node, T value)
    {
        if (node == null)
        {
            return new TreeNode<T>(value);
        }

        var cmp = value.CompareTo(node.Data);
        switch (cmp)
        {
            case < 0:
                node.Left = Add(node.Left, value);
                break;
            case > 0:
                node.Right = Add(node.Right, value);
                break;
        }
        
        // дубликаты игнорируем
        return node;
    }
    
    
    public bool Contains(T value)
    {
        return Contains(_root, value);
    }

    private bool Contains(TreeNode<T>? node, T value)
    {
        if (node == null)
        {
            return false;
        }

        var cmp = value.CompareTo(node.Data);
        return cmp switch
        {
            < 0 => Contains(node.Left, value),
            > 0 => Contains(node.Right, value),
            _ => true
        };
    }

    public void Remove(T value)
    {
        _root = Remove(_root, value);
    }

    private TreeNode<T>? Remove(TreeNode<T>? node, T value)
    {
        if (node == null)
        {
            return null;
        }

        var cmp = value.CompareTo(node.Data);
        switch (cmp)
        {
            case < 0:
                node.Left = Remove(node.Left, value);
                break;
            case > 0:
                node.Right = Remove(node.Right, value);
                break;
            default:
            {
                // Один или ноль потомков
                if (node.Left == null)
                {
                    return node.Right;
                }

                if (node.Right == null)
                {
                    return node.Left;
                }

                // Два потомка — находим минимальный в правом поддереве
                var min = FindMin(node.Right);
                node.Data = min.Data;
                node.Right = Remove(node.Right, min.Data);
                break;
            }
        }
        
        return node;
    }
    
    private TreeNode<T> FindMin(TreeNode<T> node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }

        return node;
    }
    
    private void PreOrder(TreeNode<T>? node, List<T> list)
    {
        if (node == null)
        {
            return;
        }

        list.Add(node.Data);
        PreOrder(node.Left, list);
        PreOrder(node.Right, list);
    }

    public IEnumerable<T> InOrder()
    {
        var list = new List<T>();
        InOrder(_root, list);
        return list;
    }

    private void InOrder(TreeNode<T>? node, List<T> list)
    {
        if (node == null)
        {
            return;
        }

        InOrder(node.Left, list);
        list.Add(node.Data);
        InOrder(node.Right, list);
    }

    public IEnumerable<T> PostOrder()
    {
        var list = new List<T>();
        PostOrder(_root, list);
        return list;
    }

    private void PostOrder(TreeNode<T>? node, List<T> list)
    {
        if (node == null)
        {
            return;
        }

        PostOrder(node.Left, list);
        PostOrder(node.Right, list);
        list.Add(node.Data);
    }
}