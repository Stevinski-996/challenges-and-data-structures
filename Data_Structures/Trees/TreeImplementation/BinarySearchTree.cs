namespace Trees

{

public class BinarySearchTree : BinaryTree
{
    public void Add(int data)
    {
        Root = AddRecursively(Root, data);
    }

    private Node AddRecursively(Node node, int data)
    {
        if (node == null) return new Node(data);
        if (data< node.Data)
        {
            node.Left = AddRecursively(node.Left, data);
        }
        else if (data > node.Data)
        {
            node.Right = AddRecursively(node.Right, data);
        }
        return node;
    }
    public bool Contains(int data)
    {
        return ContainsRecursively(Root, data);
    }
    private bool ContainsRecursively(Node node, int data)
    {
        if (node == null)
        {
            return false;
        }

        if (data == node.Data)
        {
            return true;
        }
        else if (data < node.Data)
        {
            return ContainsRecursively(node.Left, data);
        }
        else
        {
            return ContainsRecursively(node.Right, data);
        }
    }

    public void Remove(int data)
    {
        Root = RemoveRecursively(Root, data);
    }

    private Node RemoveRecursively(Node node, int data)
    {
        if (node == null)
        {
            return null;
        }

        if (data < node.Data)
        {
            node.Left = RemoveRecursively(node.Left, data);
        }
        else if (data > node.Data)
        {
            node.Right = RemoveRecursively(node.Right, data);
        }
        else
        {
            if (node.Left == null)
            {
                return node.Right;
            }
            else if (node.Right == null)
            {
                return node.Left;
            }

            // Node with two children: Get the inorder successor (smallest in the right subtree)
            node.Data = MinValue(node.Right);

            // Delete the inorder successor
            node.Right = RemoveRecursively(node.Right, node.Data);
        }

        return node;
    }

    private int MinValue(Node node)
    {
        int minv = node.Data;
        while (node.Left != null)
        {
            minv = node.Left.Data;
            node = node.Left;
        }
        return minv;
    }
}
}