using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new linked list
            LinkList list = new LinkList();

            // Add nodes to the list
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);

            // Print the original list
            Console.WriteLine("Original List:");
            list.Print();

            // Rotate the list to the left by 2 positions
            list = list.RotateLeft(24, list);

            // Print the list after rotating
            Console.WriteLine("List after rotating left by 2:");
            list.Print();

            // Uncomment the following blocks to test other parts of the program

            /*
            // Create lists for merging and sorting
            LinkList list1 = new LinkList();
            LinkList list_1 = new LinkList();
            int[] case1 = { 1, 3, 5 };
            int[] case_1 = { 2, 4, 6 };

            Add(list1, case1);
            Add(list_1, case_1);

            Console.WriteLine("\nCase #1");
            list1.Print();
            list_1.Print();

            // Merge and sort the lists
            list1.MergeLists(list1, list_1);
            list1.SortedList();

            Console.WriteLine("\nOutput #1");
            list1.Print();
            */

            /*
            // Example of using Queue and Stack
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.PrintQueue();
            queue.Dequeue();
            queue.PrintQueue();

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.PrintStack();
            */

            /*
            // Example of using MinStack
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);

            minStack.PrintStack();
            Console.WriteLine($"Min: {minStack.GetMin()}");

            minStack.Pop();
            minStack.PrintStack();
            Console.WriteLine($"New Min: {minStack.GetMin()}");

            minStack.Push(2);
            minStack.PrintStack();
            Console.WriteLine($"Peek: {minStack.Peek()}");
            */
        }

        // Helper method to add multiple values to a list
        static void Add(LinkList list, int[] values)
        {
            foreach (var value in values)
            {
                list.Add(value);
            }
        }
    }

    // You can place your Queue, Stack, MinStack, and other classes here
}
