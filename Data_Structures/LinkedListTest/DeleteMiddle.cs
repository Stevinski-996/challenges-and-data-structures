using System;
using Xunit;
using LinkedList;


namespace  LinkedListTest{
public class DeleteMiddle
{
   [Fact]
  public void DeleteMiddleElement_OddSizedStack_RemovesMiddleElement()
  {
      var list = new LinkList();
      var stack = new Stack();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);
      stack.Push(5);

      int removedValue = stack.DeleteMiddleElement();

      Assert.Equal(3, removedValue);
  }

  [Fact]
  public void DeleteMiddleElement_EvenSizedStack_RemovesMiddleElement()
  {
      var list = new LinkList();

      var stack = new Stack();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);

      int removedValue = stack.DeleteMiddleElement();

      Assert.Equal(2, removedValue); 
  }}}