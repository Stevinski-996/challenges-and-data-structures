// using System;
// using Xunit;
// using LinkedList;


// namespace  LinkedListTest{
// public class StackTests
// {
//     [Fact]
//     public void Push_Node_Onto_Stack()
//     {
//         // Arrange
//         Stack stack = new Stack();

//         // Act
//         stack.Push(10);

//         // Assert
//         // Assert.False(stack.IsEmpty());
//         Assert.Equal(10, stack.Peek());
//     }

//     // [Fact]
//     // public void Pop_Node_From_Stack()
//     // {
//     //     // Arrange
//     //     Stack stack = new Stack();
//     //     stack.Push(20);
//     //     stack.Push(30);

//     //     // Act
//     //     int poppedValue = stack.Pop();

//     //     // Assert
//     //     Assert.Equal(30, poppedValue);
//     //     Assert.Equal(20, stack.Peek());
//     // }

//     [Fact]
//     public void Check_If_Stack_Is_Empty()
//     {
//         // Arrange
//         Stack stack = new Stack();

//         // Act
//         bool isEmpty = stack.IsEmpty();

//         // Assert
//         Assert.True(isEmpty);
//     }
// }


// public class QueueTests
// {
//     [Fact]
//     public void Enqueue_Node_Into_Queue()
//     {
//         // Arrange
//         Queue queue = new Queue();

//         // Act
//         queue.Enqueue(10);

//         // Assert
//         Assert.False(queue.IsEmpty());
//         Assert.Equal(10, queue.Peek());
//     }

//     [Fact]
//     public void Dequeue_Node_From_Queue()
//     {
//         // Arrange
//         Queue queue = new Queue();
//         queue.Enqueue(20);
//         queue.Enqueue(30);

//         // Act
//         int dequeuedValue = queue.Dequeue();

//         // Assert
//         Assert.Equal(20, dequeuedValue);
//         Assert.Equal(30, queue.Peek());
//     }

//     [Fact]
//     public void Check_If_Queue_Is_Empty()
//     {
//         // Arrange
//         Queue queue = new Queue();

//         // Act
//         bool isEmpty = queue.IsEmpty();

//         // Assert
//         Assert.True(isEmpty);
//     }
// }
// }