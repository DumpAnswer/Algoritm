using System;

namespace Task2
{

    class Program
    {


        static void Main(string[] args)
        {
            var testData = new BinarSearch.TestCase[2];
            int[] array = new int[] { 32, 45, 43, 65, 47, 33, 24, 75, 34, 12 };
            testData[0] = new BinarSearch.TestCase()
            {

                
                searhNumber = 47,
                index = 4


            };
            
            testData[1] = new BinarSearch.TestCase()
            {
                searhNumber = 75,
                index = 7
            };
            foreach (var testCase in testData)
            {
                 int result = BinarSearch.BinarySearch(array,testCase.searhNumber);
                
                var correct = result == testCase.searhNumber;
                Console.WriteLine($"Ищю номер = {testCase.searhNumber} Ответ {result} Правельный ответ {testCase.index}  ");



            }

        }
    }
}


