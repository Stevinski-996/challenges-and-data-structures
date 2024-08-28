using System;
using Xunit;
using LinkedList;

namespace LinkedListTest
{
public class UnitTest1
{
//     [Fact]
//     public void RemoveNode()
//     {
//     LinkList list = new LinkList();
//     list.Add(5);
//     list.Add(10);
//     list.Add(20);
//     list.Add(30);
//     // list.RemoveHead(10);
//     Assert.True(list.Includes(5));
//     Assert.False(list.Includes(10));
//     Assert.True(list.Includes(20));
//     Assert.True(list.Includes(30));
//     }
//      [Fact]
//      public void PrintList(){
//         LinkList list = new LinkList();
//     list.Add(5);
//     list.Add(10);
//     list.Add(20);
//     list.Add(30);
//     using (StringWriter sw = new StringWriter()){
//     Console.SetOut(sw);
//     list.Print();
//     var expected = $"Head -> 5 -> 10 -> 20 -> 30 -> Null{Environment.NewLine}";
//     Assert.Equal(expected, sw.ToString());
//     }
//      }
//       [Fact]
//       public void RemoveDuplicate(){
            
//             LinkList list = new LinkList();
//             list.Add(5);
//             list.Add(10);
//             list.Add(5);
//             list.Add(20);
//             list.Add(10);
//             list.Add(30);

            
//             list.RemoveDuplicate();

            
//             Assert.True(list.Includes(5));
//             Assert.True(list.Includes(10));
//             Assert.True(list.Includes(20));
//             Assert.True(list.Includes(30));
//             Assert.Equal(1, CountOccurrences(list, 5));
//             Assert.Equal(1, CountOccurrences(list, 10));
//         }
//          private int CountOccurrences(LinkList list, int data)
//         {
//             int count = 0;
//             Node current = list.Head;
//             while (current != null)
//             {
//                 if (current.Data == data)
//                 {
//                     count++;
//                 }
//                 current = current.Next;
//             }
//             return count;
//         }
        
//       }
//     }
[Fact]
  public void TestGetMinAfterPush()
  {
      //Test retrieving the minimum element in the stack.
      MinStack stack = new MinStack();

      stack.Push(3);
      stack.Push(15);
      stack.Push(12);
      stack.Push(7);

      Assert.Equal(3, stack.GetMin()); 
  }

  [Fact]
  public void TestGetMinAfterPop()
  {
      // Test popping elements and verifying the minimum element in the stack after the pop.
      MinStack stack = new MinStack();

      stack.Push(10);
      stack.Push(5);
      stack.Push(20);
      stack.Pop(); // Remove 20

      // Act & Assert
      Assert.Equal(5, stack.GetMin());
      stack.Pop();
      Assert.Equal(10, stack.GetMin()); 
  }

  [Fact]
  public void TestGetMinAfterMultiplePushes()
  {
      // Test pushing elements and verifying the minimum element in the stack after the push.

      MinStack stack = new MinStack();

      stack.Push(10);
      stack.Push(20);
      stack.Push(5);
      stack.Push(15);

      Assert.Equal(5, stack.GetMin());
  }
}}