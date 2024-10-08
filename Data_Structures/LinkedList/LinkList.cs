using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkList
    {
        public int Length{get;set;}
        public Node Head;
        public LinkList()
        {
            Head = null;
        }
        public bool Includes(int input)
        {
            Node current = Head;
            if (current == null)
            {
                return false;
            }
            while (current != null)
            {
                if (current.Data == input)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public int RemoveHead()
        {
            if (IsEmpty()) Console.WriteLine("The List is Empty");

            Node fadi = Head;
            Head = fadi.Next;
            fadi.Next = null;
            return fadi.Data;

        }
        public void Add(int input)
        {
            Node newNode = new Node(input);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node? current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddToHead(int input)
        {
            Node newNode = new Node(input);
            if (IsEmpty()){
                Head = newNode;
                Length++;
                }else{
            // Insert the new node at the beginning of the list
            newNode.Next = Head;
            Head = newNode;
            Length++;
        }}

        public void Print()
        {
            Node? current = Head;
            if (current == null)
            {
                Console.WriteLine("List Is Empty");
                return;
            }
            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }

        public void RemoveDuplicate()
        {
            Node current = Head;
            while (current != null)
            {
                Node followingValue = current.Next;
                while (followingValue != null)
                {
                    if (current.Data == followingValue.Data)
                    {
                        // RemoveHead(followingValue.Data);
                        break;
                    }
                    followingValue = followingValue.Next;
                }
                current = current.Next;
            }
        }
        public Node MergeLists(LinkList list1, LinkList list2)
        {
            if (list1.IsEmpty() && list2.IsEmpty())
            {
                Console.WriteLine("Both lists are empty.");
                return null;
            }
            else if (list1.IsEmpty())
            {
                Console.WriteLine("The first list is empty.");
                return list2.Head;
            }
            else if (list2.IsEmpty())
            {
                Console.WriteLine("The second list is empty.");
                return list1.Head;
            }

            Node current1 = list1.Head;
            while (current1.Next != null)
            {
                current1 = current1.Next;
            }
            current1.Next = list2.Head;

            return list1.Head;
        }

        public void SortedList()
        {
            Node current = Head, travers = null;


            while (current != null)
            {
                travers = current.Next;

                while (travers != null)
                {
                    if (current.Data.CompareTo(travers.Data) > 0)
                    {
                        var temp = current.Data;
                        current.Data = travers.Data;
                        travers.Data = temp;
                    }
                    travers = travers.Next;
                }
                current = current.Next;
            }
        }
        public bool IsEmpty()
        {
            return Head == null;
        }
    }
}

