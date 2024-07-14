using System;
using System.Collections.Generic;

namespace FindDuplicatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 1, 2, 3 };
            List<int> output = FindDuplicates(input);

            Console.WriteLine("Output Array: ");
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }
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
    }
}
