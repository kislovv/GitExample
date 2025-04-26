using System.Collections;

namespace BinaryTree;

public class BinaryTree<T>(T rootData)
{
    private TreeNode<T>? _root = new(rootData);

    public void Add(T data)
    {
        var node = new TreeNode<T>(data);
        if (_root == null)
        {
            _root = node;
            return;
        }
        var current = _root;
        var parent = current;
        bool left = true;
        while (current != null)
        {
            var compareResult = Comparer.Default.Compare(current.Data, data);
            if (compareResult == 0)
            {
                return;
            }
            parent = current;
            parent.Height++;
            if (compareResult == 1)
            {
                current = current.Left;
                left = true;
            }
            if (compareResult == -1)
            {
                current = current.Right;
                left = false;
            }
        }

        if (left)
        {
            parent.Left = node;
        }
        else
        {
            parent.Right = node;
        }
    }
}