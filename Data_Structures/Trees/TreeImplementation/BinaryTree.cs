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

    public void MirrorTree() {
      
      MirrorTree(Root);

    }

    private void MirrorTree(Node node) 
    {
        if (node == null) return;

        MirrorTree(node.Left);
        MirrorTree(node.Right);

        Node temp = node.Left;
        node.Left = node.Right;
        node.Right = temp;
    }


    public List<int> InorderTraversal() 
    {
        List<int> result = new List<int>();
        InorderTraversal(Root, result);
        return result;
    }

    private void InorderTraversal(Node node, List<int> result)
    {
        if (node == null) return;

        InorderTraversal(node.Left, result);
        result.Add(node.Data);
        InorderTraversal(node.Right, result);

    }
    
    public int FindSecondMax() 
    {
        if (Root == null) 
        throw new InvalidOperationException("Tree is Empty");

        int max = int.MinValue;
        int secondMAx = int.MinValue;

        FindSecondMax(Root, ref max, ref secondMAx);
    
        if (secondMAx == int.MinValue)
            throw new InvalidOperationException("Tree doesnt have a Second Max Value.");

            return secondMAx; 
    }

    private void FindSecondMax(Node node, ref int max, ref int secondMAx)
    {
        if (node == null) 
            return;

        FindSecondMax(node.Left, ref max, ref secondMAx);

        if (node.Data > max)
        {
            secondMAx = max;
            max = node.Data;
        }
        else if (node.Data > secondMAx && node.Data < max)
        {
            secondMAx = node.Data;
        }
        
        FindSecondMax(node.Right, ref max, ref secondMAx);
    }
    
    public int SumOfLeafNodes()
    {
        if (Root == null)
            throw new InvalidOperationException("Tree is Empty");
    
        return SumOfLeafNodes(Root);
    
    }

    private int SumOfLeafNodes(Node node)
    {
        if (node == null)
        return 0;

        if (node.Left == null && node.Right == null)
        return node.Data;

        int leftSum = SumOfLeafNodes(node.Left);
        int rightSum = SumOfLeafNodes(node.Right);

        return leftSum + rightSum;
    }


    public List<int> LargestValueEachLevel()
    {
        List<int> largestValues = new List<int>();

        if (Root == null)
            return largestValues; // Return an empty list if the tree is empty

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            int maxAtLevel = int.MinValue;

            for (int i = 0; i < levelSize; i++)
            {
                Node current = queue.Dequeue();

                // Update the maximum value for the current level
                if (current.Data > maxAtLevel)
                {
                    maxAtLevel = current.Data;
                }

                // Enqueue the left and right children
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            // Add the maximum value found at this level to the result list
            largestValues.Add(maxAtLevel);
        }
        return largestValues;
    }
}
}
