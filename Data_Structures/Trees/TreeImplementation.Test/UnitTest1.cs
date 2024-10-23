// using BinarySearchTree;
// using BinaryTree;
using Xunit;
using Trees;
using System;

namespace TreeImplementaion.Test
{
public class UnitTest1
{
    public class RightViewTest
    {
        private void CaptureConsoleOutput(Action action, out string output)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                action.Invoke();
                output = sw.ToString();
            }
        }

    [Fact]
    public void PreOrder_ShouldReturnCorrectOrder()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);

        // Act & Assert
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            tree.PreOrder(tree.Root);
            var result = sw.ToString().Trim();
            Assert.Equal("1 \n2 \n3", result);
        }
    }

    public void InOrder_ShouldReturnCorrectOrder()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root.Left = new Node(2);
        tree.Root = new Node(1);
        tree.Root.Right = new Node(3);

        // Act & Assert
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            tree.InOrder(tree.Root);
            var result = sw.ToString().Trim();
            Assert.Equal("2 1 3", result);
        }

    }
    public void PostOrder_ShouldReturnCorrectOrder()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root = new Node(1);

        // Act & Assert
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            tree.PostOrder(tree.Root);
            var result = sw.ToString().Trim();
            Assert.Equal("2 3 1", result);
        }
    }
    public class BinarySearchTreeTests
{
    [Fact]
    public void Add_ShouldAddNodeCorrectly()
    {
        // Arrange
        BinarySearchTree bst = new BinarySearchTree();

        // Act
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);

        // Assert
        Assert.True(bst.Contains(10));
        Assert.True(bst.Contains(5));
        Assert.True(bst.Contains(15));
    }

    [Fact]
    public void Remove_ShouldRemoveNodeCorrectly()
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(7);

        bst.Remove(5);

        Assert.False(bst.Contains(5));
    }
}

     [Fact]
            public void TestMirrorTree()
            {
                BinaryTree tree = new BinaryTree();
                tree.Root = new Node(4);
                tree.Root.Left = new Node(8);
                tree.Root.Right = new Node(7);
                tree.Root.Left.Left = new Node(12);
                tree.Root.Left.Right = new Node(9);

                List<int> originalInorder = tree.InorderTraversal();
                tree.MirrorTree();
                List<int> mirroredInorder = tree.InorderTraversal();

                Assert.Equal(new List<int> { 12, 8, 9, 4, 7 }, originalInorder);
                Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
            }

        [Fact]

            public void TestFindSecondMax()
            {
              BinaryTree Btree = new BinaryTree();
                Btree.Root = new Node(10);
                Btree.Root.Left = new Node(5);
                Btree.Root.Right = new Node(20);
                Btree.Root.Left.Left = new Node(3);
                Btree.Root.Left.Right = new Node(7);
                Btree.Root.Right.Left = new Node(15);
                Btree.Root.Right.Right = new Node(25);

                int result = Btree.FindSecondMax();
                Assert.Equal(20, result);
            }

        [Fact]

            public void TestSumOfLeaf_PositiveValues()
            {
              BinaryTree Btree = new BinaryTree();
                Btree.Root = new Node(9);
                Btree.Root.Left = new Node(8);
                Btree.Root.Right = new Node(12);
                Btree.Root.Left.Left = new Node(3);
                Btree.Root.Left.Right = new Node(7);
                Btree.Root.Right.Left = new Node(17);
                Btree.Root.Right.Right = new Node(23);
                Btree.Root.Left.Left.Right = new Node(4);

                int result = Btree.SumOfLeafNodes();
                Assert.Equal(51, result);

            }
        
        [Fact]

            public void TestSumOfLeaf_NegativeValues()
            {
              BinaryTree Btree = new BinaryTree();
                Btree.Root = new Node(9);
                Btree.Root.Left = new Node(-8);
                Btree.Root.Right = new Node(12);
                Btree.Root.Left.Left = new Node(-3);
                Btree.Root.Left.Right = new Node(-7);
                Btree.Root.Right.Left = new Node(17);
                Btree.Root.Right.Right = new Node(-23);
                Btree.Root.Left.Left.Right = new Node(-4);

                int result = Btree.SumOfLeafNodes();
                Assert.Equal(-17, result);  
            }

        [Fact]
            public void TestLargestValueEachLevel_WithNormalValues()
            {
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

                List<int> result = Btree.LargestValueEachLevel();
                Assert.Equal(new List<int> { 5, 13, 20, 11 }, result);
            }
            [Fact]
        public void Test_RightView_CorrectOutput()
        {
            // Arrange
            BinaryTree BTree = new BinaryTree();
            BTree.Root = new Node(2);
            BTree.Root.Left = new Node(3);
            BTree.Root.Right = new Node(5);
            BTree.Root.Left.Left = new Node(4);
            BTree.Root.Right.Right = new Node(6);
            BTree.Root.Left.Left.Right = new Node(7);

            // Act
            CaptureConsoleOutput(() => BTree.PrintRightView(), out string output);

            // Assert
            Assert.Equal($"2{Environment.NewLine}5{Environment.NewLine}6{Environment.NewLine}7{Environment.NewLine}", output);
        }

        [Fact]
        public void Test_RightView_OnlyRightNodes()
        {
            // Arrange
            BinaryTree BTree = new BinaryTree();
            BTree.Root = new Node(1);
            BTree.Root.Right = new Node(2);
            BTree.Root.Right.Right = new Node(3);
            BTree.Root.Right.Right.Right = new Node(4);

            // Act
            CaptureConsoleOutput(() => BTree.PrintRightView(), out string output);

            // Assert
            Assert.Equal($"1{Environment.NewLine}2{Environment.NewLine}3{Environment.NewLine}4{Environment.NewLine}", output);
        }
        [Fact]
        public void FindMaxLevelNodes_CorrectLevel_ReturnsMaxNodesLevel()
        {
            // Arrange
            BinaryTree BTree = new BinaryTree();
            BTree.Root = new Node(1);
            BTree.Root.Left = new Node(2);
            BTree.Root.Right = new Node(3);
            BTree.Root.Left.Left = new Node(4);
            BTree.Root.Left.Right = new Node(5);
            BTree.Root.Right.Right = new Node(7);
            BTree.Root.Left.Left.Left = new Node(8);
            BTree.Root.Left.Right.Left = new Node(9);
            BTree.Root.Right.Right.Left = new Node(10);

            // Act
            int maxLevel = BTree.FindMaxLevelNodes(); 

            // Assert
            Assert.Equal(2, maxLevel); 
        }

        [Fact]
        public void FindMaxLevelNodes_AllLevelsSameNumberOfNodes_ReturnsFirstLevelWithMaxNodes()
        {
            // Arrange
            BinaryTree BTree = new BinaryTree();
            BTree.Root = new Node(1);
            BTree.Root.Left = new Node(2);
            BTree.Root.Right = new Node(3);
            BTree.Root.Left.Left = new Node(4);
            BTree.Root.Left.Right = new Node(5);
            BTree.Root.Right.Right = new Node(6);
            BTree.Root.Left.Left.Left = new Node(7);
            BTree.Root.Left.Left.Right = new Node(8);
            BTree.Root.Right.Left = new Node(9);
            BTree.Root.Right.Right.Left = new Node(10);
            BTree.Root.Right.Right.Right = new Node(11);

            // Act
            int result = BTree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result); 
        }
        }
        [Fact]
        public void Test_MinimumDepth_WithMultipleNodes_VaryingDepths()
        {
            // Arrange
            BinaryTree BTree = new BinaryTree();
            BTree.Root = new Node(1);
            BTree.Root.Left = new Node(2);
            BTree.Root.Right = new Node(3);
            BTree.Root.Left.Left = new Node(4);
            BTree.Root.Left.Right = new Node(5);

            // Act
            int minDepth = BTree.FindMinDepth();

            // Assert
            Assert.Equal(2, minDepth);  
        }

        
    }}
