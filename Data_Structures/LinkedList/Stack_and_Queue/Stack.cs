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

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Push(int data)
        {
            list.AddToHead(data);
        }

        public int Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            return list.RemoveHead();
        }

        public int Peek()
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
}