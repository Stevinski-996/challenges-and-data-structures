using System;
using System.Collections.Generic;

namespace FindDuplicatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 1, 2, 3 };
            int[] input2 = { 16, 8, 31, 17, 15, 23, 17 ,8};
            int[] input3 = { 5, 10, 16, 20, 10, 16};
            List<int> output = FindDuplicates(input);
            List<int> output2 = FindDuplicates(input2);
            List<int> output3 = FindDuplicates(input3);
            Console.WriteLine("\nDuplicated Output1 Array: ");
            printValues(output);
            Console.WriteLine("\nDuplicated Output2 Array: ");
            printValues(output2);
            Console.WriteLine("\nDuplicated Output3 Array: ");
            printValues(output3);
        }

        public static List<int> FindDuplicates(int[] input)
        {
            List<int> duplicates = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j] && !duplicates.Contains(input[i]))
                    {
                        duplicates.Add(input[i]);
                        break;
                    }
                }
            }

            return duplicates;
        }
        public static void printValues(List<int> output) {

            foreach (var item in output)
            {
                Console.Write(item + " ");
            }
        }
    }
}
