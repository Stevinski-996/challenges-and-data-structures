using System;
using Xunit;
using LinkedList;


namespace  LinkedListTest{
public class ReverseList {
    [Fact]
 public void ReverseStack_WithMultipleElements_ShouldReverseStack()
 {
     // Test reversing a stack with multiple elements.

     var stack = new Stack();
     stack.Push(1);
     stack.Push(2);
     stack.Push(3);
     stack.Push(4);
     stack.Push(5);

     stack.ReverseStack();

     Assert.Equal(1, stack.Pop());
     Assert.Equal(2, stack.Pop());
     Assert.Equal(3, stack.Pop());
     Assert.Equal(4, stack.Pop());
     Assert.Equal(5, stack.Pop());
 }

 [Fact]
 public void ReverseStack_WithSingleElement_ShouldNotChangeStack()
 {
     // Test reversing a stack with only one element.
     var stack = new Stack();
     stack.Push(1);

     stack.ReverseStack();

     Assert.Equal(1, stack.Pop());
 }

 [Fact]
 public void ReverseStack_WithEmptyStack_ShouldNotThrow()
 {
     // Test reversing an empty stack.
     var stack = new Stack();
     stack.ReverseStack();

     Assert.True(stack.IsEmpty());
 }

}}