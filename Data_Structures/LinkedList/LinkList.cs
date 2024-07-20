using System;
using System.Collections.Generic;

namespace  LinkedList {
public class LinkList{

public Node Head;
public LinkList()
{
    Head = null;
}
public bool Includes(int input) {
    Node current = Head;
    if (current == null) {
        return false;}
    while (current != null) {
        if (current.Data == input){
            return true;
        }
        current = current.Next;
    }
     return false;
}
public void Remove(int input)
        {
            if (Head == null)
            {
                Console.WriteLine("List Is Empty");
                return;
            }

            if (Head.Data == input)
            {
                Head = Head.Next;
                return;
            }

            Node? current = Head;
            while (current?.Next != null)
            {
                if (current.Next.Data == input)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
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
    }
}
