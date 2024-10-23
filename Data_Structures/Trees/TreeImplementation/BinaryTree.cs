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
        private int maxLevel = 0;
        private object value;

        public void PrintRightView()
        {
            try
            {
                if (Root == null)
                {
                    Console.WriteLine("The tree is empty.");
                    return;
                }

                PrintRightViewUtil(Root, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void PrintRightViewUtil(Node node, int currentLevel)
        {
            if (node == null)
                return;


            if (maxLevel < currentLevel)
            {
                Console.WriteLine(node.Data);
                maxLevel = currentLevel;
            }


            PrintRightViewUtil(node.Right, currentLevel + 1);
            PrintRightViewUtil(node.Left, currentLevel + 1);
        }

        //Max Level Nodes
        // Helper function to get the height of the tree
        public int GetHeight(Node node)
        {
            if (node == null)
                return 0;

            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        // Helper function to count nodes at a given level
        public int CountNodesAtLevel(Node node, int level)
        {
            if (node == null)
                return 0;

            if (level == 0)
                return 1;

            int leftCount = CountNodesAtLevel(node.Left, level - 1);
            int rightCount = CountNodesAtLevel(node.Right, level - 1);

            return leftCount + rightCount;
        }

        // Method to find the level with the maximum number of nodes
        public int FindMaxLevelNodes()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return -1; // Return -1 for an empty tree
            }

            int treeHeight = GetHeight(Root);
            int maxNodes = 0;
            int maxLevel = 0;

            for (int level = 0; level < treeHeight; level++)
            {
                int nodeCount = CountNodesAtLevel(Root, level);
                if (nodeCount > maxNodes)
                {
                    maxNodes = nodeCount;
                    maxLevel = level;
                }
            }

            return maxLevel;
        }

}
}
