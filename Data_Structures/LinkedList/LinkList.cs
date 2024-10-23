using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkList
    {
        public int Length { get; set; }
        public Node Head { get; set; }

        public LinkList()
        {
            Head = null;
            Length = 0;
        }

        // Check if the list includes a specific value
        public bool Includes(int input)
        {
            Node current = Head;
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

        // Remove the head node
        public int RemoveHead()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The List is Empty");
                return -1; // Indicate failure if the list is empty
            }

            Node oldHead = Head;
            Head = oldHead.Next;
            oldHead.Next = null;
            Length--;
            return oldHead.Data;
        }

        // Add a new node to the end of the list
        public void Add(int input)
        {
            Node newNode = new Node(input);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Length++;
        }

        // Add a new node to the head of the list
        public void AddToHead(int input)
        {
            Node newNode = new Node(input);
            newNode.Next = Head;
            Head = newNode;
            Length++;
        }

        // Print the list
        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List Is Empty");
                return;
            }

            Node current = Head;
            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }

        // Remove duplicates from the list
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
                        // RemoveHead() can be implemented to remove this node.
                        break;
                    }
                    followingValue = followingValue.Next;
                }
                current = current.Next;
            }
        }

        // Merge two lists
        public Node MergeLists(LinkList list1, LinkList list2)
        {
            if (list1.IsEmpty() && list2.IsEmpty())
            {
                Console.WriteLine("Both lists are empty.");
                return null;
            }
            if (list1.IsEmpty())
            {
                Console.WriteLine("The first list is empty.");
                return list2.Head;
            }
            if (list2.IsEmpty())
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

        // Sort the list
        public void SortedList()
        {
            Node current = Head;
            while (current != null)
            {
                Node travers = current.Next;
                while (travers != null)
                {
                    if (current.Data.CompareTo(travers.Data) > 0)
                    {
                        // Swap data
                        int temp = current.Data;
                        current.Data = travers.Data;
                        travers.Data = temp;
                    }
                    travers = travers.Next;
                }
                current = current.Next;
            }
        }

        // Check if the list is empty
        public bool IsEmpty()
        {
            return Head == null;
        }

        // Rotate the list to the left by k positions
        public LinkList RotateLeft(int k, LinkList inputList)
        {
            if (inputList == null || k == 0)
            {
                return inputList;
            }

            Node currentNode = inputList.Head;
            int listLength = 1;

            // Find the length of the list
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                listLength++;
            }

            // Connect the last node to the head, forming a circular list
            currentNode.Next = inputList.Head;

            // Adjust k if it's greater than the length of the list
            k = k - listLength;

            // Traverse to the node just before the new head
            for (int i = 0 ; i < k; i++)
            {
                currentNode = currentNode.Next;
            }

            // Set the new head of the list
            inputList.Head = currentNode.Next;

            // Break the circular connection
            currentNode.Next = null;

            return inputList;
        }

        // Helper method to add a node
        public void AddNode(int value)
        {
            Add(value);
        }
    }
    }