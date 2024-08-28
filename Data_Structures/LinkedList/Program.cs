using System;
using System.Collections.Generic;

namespace LinkedList
{

    public class Program
    {

        public static void Main(string[] args)
        {
            //    LinkList list = new LinkList();

            //     LinkList list1 = new LinkList();
            //     LinkList list_1 = new LinkList();
            //     LinkList list2 = new LinkList();
            //     LinkList list_2 = new LinkList();
            //     LinkList list3 = new LinkList();
            //     LinkList list_3 = new LinkList();

            //     int[] case1 = { 1, 3, 5 };
            //     int[] case_1 = { 2, 4, 6 };
            //     int[] case2 = { 5, 10, 15 };
            //     int[] case_2 = { 2, 3, 20 }; 
            //     int[] case3 = { 10, 20, 30 };
            //     int[] case_3 = { 5, 15, 25, 35 };

            //     Add(list1, case1);
            //     Add(list_1, case_1);

            //     Console.WriteLine("\nCase #1");
            //     list1.Print();
            //     list_1.Print();
            //     // Merge and sort
            //     list1.MergeLists(list1, list_1);
            //     list1.SortedList();

            //     Console.WriteLine("\nOutput #1");
            //     list1.Print();

            //     Add(list2, case2);
            //     Add(list_2, case_2);

            //     Console.WriteLine("\nCase #2");
            //     list2.Print();
            //     list_2.Print();
            //     // Merge and sort
            //     list2.MergeLists(list2, list_2);
            //     list2.SortedList();

            //     Console.WriteLine("\nOutput #2");
            //     list2.Print();

            //     Add(list3, case3);
            //     Add(list_3, case_3);

            //     Console.WriteLine("\nCase #3");
            //     list3.Print();
            //     list_3.Print();
            //     // Merge and sort
            //     list3.MergeLists(list3, list_3);
            //     list3.SortedList();

            //     Console.WriteLine("\nOutput #3");
            //     list3.Print();

            //     Console.ReadKey();
            // }

            // static void Add(LinkList list, int[] values)
            // {
            //     foreach (var value in values)
            //     {
            //         list.Add(value);
            //     }
            // }
            // Queue queue= new Queue();
            // Stack stack = new Stack();
            // queue.IsEmpty();
            // queue.Enqueue(10);
            // queue.Enqueue(20);
            // queue.PrintQueue();
            // queue.Peek();
            // queue.Dequeue();
            // queue.PrintQueue();
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);
            // stack.Push(4);
            // stack.Push(5);

            MinStack minStack = new MinStack();

        // Push elements
minStack.Push(15); // Top -> 15 (min: 15)
minStack.Push(7);  // Top -> 7 -> 15 (min: 7) 
minStack.Push(12); // Top -> 12 -> 7 -> 15 (min: 7)
minStack.Push(3);  // Top -> 3 -> 12 -> 7 -> 15 (min: 3) 

// Print the stack
minStack.PrintStack(); // Output: Top -> 3 -> 12 -> 7 -> 15

// Get the minimum element
int min = minStack.GetMin(); // min: 3
Console.WriteLine(min);

// Pop a node from the stack
int popped = minStack.Pop(); // popped: 3
minStack.PrintStack(); // Output: Top -> 12 -> 7 -> 15

// Get the new minimum element
min = minStack.GetMin(); // min: 7
Console.WriteLine(min);

// Peek the top node
int peeked = minStack.Peek(); // peeked: 12
Console.WriteLine(peeked);
minStack.PrintStack();

// Push another element
minStack.Push(2);  // Top -> 2 -> 12 -> 7 -> 15 (min: 2)
minStack.PrintStack(); // Output: Top -> 2 -> 12 -> 7 -> 15

// Get the new minimum element
min = minStack.Peek(); // min: 2
Console.WriteLine(min);

// Check if the stack is empty
bool isEmpty = minStack.IsEmpty(); // isEmpty: false
    }
}
}