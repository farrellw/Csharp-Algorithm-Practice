using System;

namespace Practice
{
    namespace Converter {

        public class Manipulator
        {
            public static string stringMultiplier(string inputString, int inputNumber, bool status)
            {
                //code is executed when run the application
                //void is the return type of the method
                string outputString = " ";
                if (status) {
                    for (int a = 0; a < inputNumber; a = a + 1)
                    {
                    outputString = outputString + inputString;
                    }
                } else {
                    outputString = inputString + inputNumber.ToString();
                }
                return outputString;
            }

            public static void numberManipulator()
            {
                try
                {
                    var number = 5;
                    byte b = Convert.ToByte(number);
                    Console.WriteLine(b);
                    Console.WriteLine("It was successful");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("There was an error");
                
                }
            }

            public static int Adder(int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            }


            public static char[] reverser(char[] inputArray)
            {
                //Find the bottom index and top index
                //swap them.  Move towards middle.
                //Swap and move towards middle until you hit the middle.
                int count = 0;
                int topIndex = inputArray.Length - 1;
                for (int i = count; i < topIndex / 2; i = i + 1) {
                    char priorChar = inputArray[i];
                    inputArray[i] = inputArray[topIndex - i];
                    inputArray[topIndex - i] = priorChar; 
                }
                return inputArray;
            }
        }
    }
}
