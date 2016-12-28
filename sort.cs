using System;

namespace Practice
{
    public class Sort 
    {
        public static char[] sorter(char[] inputArray)
        {
            int inputLength = inputArray.Length;
            char[] outputArray = new char[inputLength];
            outputArray[0] = inputArray[0];
            for (var i = 1; i < inputLength; i = i + 1)
            {
                char charToSort = inputArray[i];
                for (var j = 0; j < i + 1; j = j + 1)
                {
                    if (charToSort <= outputArray[j]) {
                        for (var k = i; k > j; k = k - 1)
                        {
                            exchanger(outputArray, k, k-1);
                        }
                        outputArray[j] = charToSort;
                    }
                    else if (j == i)
                    {
                        outputArray[j] = charToSort;
                    }
                }
            }

            Console.WriteLine(outputArray);
            return outputArray;
        }

        private static void exchanger(char[] array, int indexOne, int indexTwo)
        {
            char temporary = array[indexOne];
            array[indexOne] = array[indexTwo];
            array[indexTwo] = temporary;
        }


    }
}