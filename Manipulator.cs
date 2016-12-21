using System;

namespace ConsoleApplication
{
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
    }
}
