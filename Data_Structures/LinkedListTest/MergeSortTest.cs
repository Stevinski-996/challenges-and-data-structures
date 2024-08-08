using System;
using Xunit;
using LinkedList;

namespace LinkedListTest
{
public class MergeSortTest
{
    private void AddToLinkedList(LinkList list, int[] values)
{
    foreach (var value in values)
        list.Add(value);
}
private int[] GetValues(LinkList list)
{
    var values = new List<int>();
    var current = list.Head;
    while (current != null)
    {
        values.Add(current.Data);
        current = current.Next;
    }

    return values.ToArray();
}

[Fact]
public void Test_Merging_When_One_List_Is_Empty()
{
    var list = new LinkList();
    var list1 = new LinkList();
    var list2 = new LinkList();

    int[] case1 = { 1, 3, 5 };

    AddToLinkedList(list1, case1);

    list.Head = list.MergeLists(list1, list2);
    var result = GetValues(list);

    Assert.Equal(new int[] { 1, 3, 5 }, result);
}
[Fact]
public void Test_Merging_When_Both_Lists_Are_Empty()
{
    var list = new LinkList();
    var list1 = new LinkList();
    var list2 = new LinkList();

    list.Head = list.MergeLists(list1, list2);
    var result = GetValues(list);

    Assert.Empty(result);
}
[Fact]
public void Test_Merging_List1_And_List2_From_Example()
{
    // Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null

    var list = new LinkList();
    var list1 = new LinkList();
    var list2 = new LinkList();

    int[] case2 = { 5, 10, 15 };
    int[] case_2 = { 2, 3, 20 };

    AddToLinkedList(list1, case2);
    AddToLinkedList(list2, case_2);

    list.Head = list.MergeLists(list1, list2);
    list.SortedList();
    var result = GetValues(list);

    Assert.Equal(new int[] { 2 , 3 , 5 , 10 , 15 , 20  }, result);
}
}
}