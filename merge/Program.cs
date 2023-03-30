using System;
using System.Linq;

namespace merge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5] { 6, 7, 8, 9, 10 };
            //int[] merged = new int[10];
            int[] merged = arr1.Concat(arr2).ToArray();
            for(int i=0;i< merged.Length;i++)
            {
                Console.Write(merged[i] + " ");
            }
        }
    }
}
