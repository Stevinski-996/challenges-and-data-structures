using System;
using System.Collections.Generic;

namespace LinkedList { 
  public class Queue
    {
            LinkList list;
            public Queue()
            {
                list = new LinkList();
            }

            public bool IsEmpty()
            {
                return list.IsEmpty();
            }

            public void Enqueue(int data)
            {
               list.Add(data);
            }

            public int Dequeue()
            {
                if (IsEmpty()) {
                throw new InvalidOperationException("Queue is empty");}

                return list.RemoveHead();
            }

            public int Peek()
            {
                if (IsEmpty()) {
                throw new InvalidOperationException("Queue is empty");
                }
                return list.Head.Data;
            }

        public void PrintQueue()
        {
            list.Print();
        }
    }
}