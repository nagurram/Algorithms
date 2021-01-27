using System;

namespace Algorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = new int[6] { 2, 5, 7, 8, 10, 23 };
            Console.WriteLine("binary search result is " + binarySearch(arr, 5));
        }

        public static int SequentialSearch(int[] intarr, int num)
        {
            int _result = -1;
            int i = 0;
            while (i < intarr.Length)
            {
                if (intarr[i] == num)
                {
                    return i;
                }
                i++;
            }
            return _result;
        }

        public static int binarySearch(int[] intarr, int num)
        {
            int _result = -1;
            int low = 0;
            int mid = 0;
            int high = intarr.Length;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (intarr[mid] == num)
                {
                    return mid;
                }
                else
                {
                    if (intarr[mid] < num)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return _result;
        }
    }
}