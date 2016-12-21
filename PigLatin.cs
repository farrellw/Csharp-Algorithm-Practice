using System;

namespace ConsoleApplication
{

    public class PigLatin
    {
        public static string converter(string inputString)
        {
            string outputString;
            if (isVowel(inputString[0])) {
                outputString = inputString + "way";
            } else {
                outputString = adjuster(inputString);
            }  
            return outputString;
        }

        public static string adjuster(string inputString) 
        {
            string outputString = inputString;
            if (!isVowel(outputString[0]))
            { outputString = inputString.Substring(1, inputString.Length - 1) + inputString[0];
                converter(outputString);
            };
            outputString = outputString + "ay";
            return outputString;
        }
        private static bool isVowel(char inputChar) 
        {
            char[] arrayVowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < arrayVowels.Length; i = i + 1) {
                if (inputChar == arrayVowels[i]) {
                    return true;
                }
            }
            return false;
        }
    }
}
