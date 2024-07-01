using System;
using System.Collections.Generic;

namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3 };
            int[] arr2 = { 6, 5, 7, 4, 2, 3 };
            int[] result = CommonElements(arr1, arr2);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int y = 0; y < arr2.Length; y++)
                {
                    if (arr1[i] == arr2[y])
                    {
                        list.Add(arr1[i]);
                        break;
                    }
                }
            }
            return list.ToArray();
        }
    }
}