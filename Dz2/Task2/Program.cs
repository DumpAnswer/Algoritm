using System;

namespace Task2
{
    
        class Program
        {
            static void Main(string[] args)
            {
            BinarSearch binarSearch = new BinarSearch();

            int[] inputArray = new int[] { 1, 3, 5, 6, 7, 34, 64, 123, 43, 68, 32, 55, 66, 88 };

                BinarSearch.binarSearch(inputArray, 64);


            }
        }
    }


