namespace Trees {

    public class Program{


static void Main(string[] args)
{
    // BinarySearchTree bst = new BinarySearchTree();
    // bst.Add(10);
    // bst.Add(5);
    // bst.Add(15);
    // bst.Add(7);

    // Console.WriteLine("Binary Search Tree:");
    // bst.Print(bst.Root);

    // BinaryTree Btree = new BinaryTree();
    //         Btree.Root = new Node(4);
    //         Btree.Root.Left = new Node(8);
    //         Btree.Root.Right = new Node(7);
    //         Btree.Root.Left.Left = new Node(12);
    //         Btree.Root.Left.Right = new Node(9);

    // Console.WriteLine("Binary Tree:");
    // Btree.Print(Btree.Root);

    //         List<int> originalInorder = Btree.InorderTraversal();
    //         Console.WriteLine("Original Inorder Traversal: " + string.Join(", ", originalInorder));

    // Btree.MirrorTree();

    //         List<int> mirroredInorder = Btree.InorderTraversal();
    //         Console.WriteLine("Mirrored Inorder Traversal: " + string.Join(", ", mirroredInorder));

    // Console.WriteLine("Mirrored Binary Tree:");
    // Btree.Print(Btree.Root);

    // Console.WriteLine("Press any key to exit...");
    //         Console.ReadKey();


    //SecondMax : 
    // BinaryTree Btree = new BinaryTree();
    //     Btree.Root = new Node(10);
    //     Btree.Root.Left = new Node(5);
    //     Btree.Root.Right = new Node(20);
    //     Btree.Root.Left.Left = new Node(3);
    //     Btree.Root.Left.Right = new Node(7);
    //     Btree.Root.Right.Left = new Node(15);
    //     Btree.Root.Right.Right = new Node(25);

        
    //     int secondMax = Btree.FindSecondMax();
    //     Console.WriteLine("Second Maximum Value: " + secondMax); // Output: 20
        

    //Summing Leafs : 
    // BinaryTree Btree = new BinaryTree();
    //     Btree.Root = new Node(9);
    //     Btree.Root.Left = new Node(8);
    //     Btree.Root.Right = new Node(12);
    //     Btree.Root.Left.Left = new Node(3);
    //     Btree.Root.Left.Right = new Node(7);
    //     Btree.Root.Right.Left = new Node(17);
    //     Btree.Root.Right.Right = new Node(23);
    //     Btree.Root.Left.Left.Right = new Node(4);

    //     try
    //     {
    //         int leafSum = Btree.SumOfLeafNodes();
    //         Console.WriteLine("Sum of Leaf Nodes: " + leafSum); 
    //     }
    //     catch (InvalidOperationException ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     }


    //Maximum At Each Level : 
     BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(5);
        Btree.Root.Left = new Node(13);
        Btree.Root.Right = new Node(7);
        Btree.Root.Left.Left = new Node(3);
        Btree.Root.Left.Right = new Node(7);
        Btree.Root.Right.Left = new Node(12);
        Btree.Root.Right.Right = new Node(20);
        Btree.Root.Left.Left.Left = new Node(1);
        Btree.Root.Left.Left.Right = new Node(4);
        Btree.Root.Right.Left.Right = new Node(11);

        List<int> largestValues = Btree.LargestValueEachLevel();
        Console.WriteLine("Largest Values at Each Level: " + string.Join(", ", largestValues)); // Output: [5, 13, 20, 11]

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
}

}
}