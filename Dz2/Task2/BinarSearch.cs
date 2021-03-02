using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class BinarSearch
    {
        public class TestCase
        {
            public int searhNumber { get; set; }
            public int index { get; set; }
        }


        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

    }
}
