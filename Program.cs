using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //RomanNumeralGenerator object2 = new ConsoleApplication.RomanNumeralGenerator(1792);
            //Console.WriteLine(object2.displayString);
            //Person object1 = new ConsoleApplication.Person("Harry");
            Console.WriteLine(ConsoleApplication.PigLatin.converter("pig"));
            Console.WriteLine(ConsoleApplication.PigLatin.converter("thorough"));
            Console.WriteLine(ConsoleApplication.PigLatin.converter("everything"));
            //code is executed when run the application
            //void is the return type of the method
            //int sum = Adder(3, 4);
            //string printStringer = Writer("potato");
            //bool variant = 4 < 3;
            //string printStringerTwo = ConsoleApplication.Manipulator.stringMultiplier("HelloWorld. ", 42, variant);
            //ConsoleApplication.Manipulator.numberManipulator();
            //object1.ager(69);
            //Console.WriteLine(object1.age);
            //object1.ager(100);
            //Console.WriteLine(object1.age);
            //Console.WriteLine(sum);
            //Console.WriteLine(printStringerTwo);
        }

        public static string Writer(string variable)
        {
            return "The writer method was called and it is displaying a " + variable;
        }
    }
}
