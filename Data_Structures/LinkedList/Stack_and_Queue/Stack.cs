using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Stack
    {
        private LinkList list;

        public Stack()
        {
            list = new LinkList();
        }

        public virtual bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public virtual void Push(int data)
        {
            list.AddToHead(data);
        }

        public virtual int Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            return list.RemoveHead();
        }

        public virtual int Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            return list.Head.Data;
        }

        public void PrintStack()
        {
            list.Print();
        }
        public void ReverseStack()
        {
            if (IsEmpty()) return;

            Queue queue = new Queue();

            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }

            while (!queue.IsEmpty())
            {
                Push(queue.Dequeue());
            }
        }
        public int DeleteMiddleElement()
 {
     if (IsEmpty() || list.Length == 1)
     {
         throw new InvalidOperationException("Stack does not have a middle element");
     }

     int midPosition = list.Length / 2;
     Node current = list.Head;
     Node previous = null;

     for (int i = 0; i < midPosition; i++)
     {
         previous = current;
         current = current.Next;
     }

     int removedValue = current.Data;

     if (previous != null)
     {
         previous.Next = current.Next;
     }
     else
     {
         list.Head = current.Next;
     }

     list.Length--;

     return removedValue;
 }


    }
    public class MinStack : Stack
    {
        private Stack minStack;

        public MinStack() : base()
        {
            minStack = new Stack();
        }

        public override void Push(int data)
        {
            base.Push(data);

            if (minStack.IsEmpty() || data <= minStack.Peek())
            {
                minStack.Push(data);
            }
        }
        public override int Pop()
        {
            int poppedValue = base.Pop();

            if (poppedValue == minStack.Peek())
            {
                minStack.Pop();
            }

            return poppedValue;
        }

        public int GetMin()
        {
            if (minStack.IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return minStack.Peek();
        }
    }
}