using System;
using Xunit;
using LinkedList;

namespace LinkedListTest
{
public class UnitTest1
{
    [Fact]
    public void RemoveNode()
    {
    LinkList list = new LinkList();
    list.Add(5);
    list.Add(10);
    list.Add(20);
    list.Add(30);
    list.Remove(10);
    Assert.True(list.Includes(5));
    Assert.False(list.Includes(10));
    Assert.True(list.Includes(20));
    Assert.True(list.Includes(30));
    }
     [Fact]
     public void PrintList(){
        LinkList list = new LinkList();
    list.Add(5);
    list.Add(10);
    list.Add(20);
    list.Add(30);
    using (StringWriter sw = new StringWriter()){
    Console.SetOut(sw);
    list.Print();
    var expected = $"Head -> 5 -> 10 -> 20 -> 30 -> Null{Environment.NewLine}";
    Assert.Equal(expected, sw.ToString());
    }
     }
    }
}