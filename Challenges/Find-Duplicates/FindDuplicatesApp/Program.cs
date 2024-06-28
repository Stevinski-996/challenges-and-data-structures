using System;
using System.Collections.Generic;

namespace FindDuplicatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 1, 2, 3 };
            int[] array2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
            int[] array3 = { 5, 10, 16, 20, 10, 16 };

            Console.WriteLine("Duplicates in array1: " + string.Join(", ", FindDuplicates(array1)));
            Console.WriteLine("Duplicates in array2: " + string.Join(", ", FindDuplicates(array2)));
            Console.WriteLine("Duplicates in array3: " + string.Join(", ", FindDuplicates(array3)));
        }

        static int[] FindDuplicates(int[] array)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            List<int> duplicates = new List<int>();

            // Count occurrences of each element
            foreach (int num in array)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            // Collect elements that appear more than once
            foreach (var kvp in counts)
            {
                if (kvp.Value > 1)
                {
                    duplicates.Add(kvp.Key);
                }
            }

            return duplicates.ToArray();
        }
    }
}
