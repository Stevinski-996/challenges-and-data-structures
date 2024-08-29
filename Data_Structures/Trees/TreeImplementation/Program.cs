namespace Trees {

    public class Program{


static void Main(string[] args)
{
    BinarySearchTree bst = new BinarySearchTree();
    bst.Add(10);
    bst.Add(5);
    bst.Add(15);
    bst.Add(7);

    Console.WriteLine("Binary Search Tree:");
    bst.Print(bst.Root);
}
}
}