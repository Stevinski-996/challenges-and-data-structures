namespace Trees
{

public class BinaryTree
{
    public Node Root {get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void PreOrder(Node node)
    {
        if (node == null) return;

        System.Console.WriteLine(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
        }

    public void InOrder (Node node) 
    {

        if (node == null) return;

        InOrder(node.Left);
        System.Console.WriteLine(node.Data + " ");
        InOrder(node.Right);
    }

    public void PostOrder(Node node)
    {
    if (node == null) return;

        PostOrder(node.Left);
        InOrder(node.Right);
        System.Console.WriteLine(node.Data + " ");
    }

    public void Print(Node node, string indent = "", bool isLeft = true)
    {
         if (node == null) return;

        Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + node.Data);
        indent += isLeft ? "│   " : "    ";

        Print(node.Left, indent, true);
        Print(node.Right, indent, false);
    }
}
}