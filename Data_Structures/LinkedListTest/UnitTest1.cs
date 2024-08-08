// using System;
// using Xunit;
// using LinkedList;

// namespace LinkedListTest
// {
// public class UnitTest1
// {
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
