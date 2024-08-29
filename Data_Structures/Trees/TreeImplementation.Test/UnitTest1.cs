// using BinarySearchTree;
// using BinaryTree;
using Xunit;
using Trees;
using System;

namespace TreeImplementaion.Test
{
public class UnitTest1
{
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

    }}