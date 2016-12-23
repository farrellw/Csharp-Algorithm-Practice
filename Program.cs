using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60 };
            int[] numbersTwo = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            int returnedOne = ConsoleApplication.BinarySearch.searcher(numbers, 55, 0, numbers.Length);
            Console.WriteLine(returnedOne);
            //int returnedTwo = ConsoleApplication.BinarySearch.searcher(numbersTwo, 3, 0, numbersTwo.Length);
            //Console.WriteLine(returnedTwo);
        }

        public static string Writer(string variable)
        {
            return "The writer method was called and it is displaying a " + variable;
        }
    }
}
