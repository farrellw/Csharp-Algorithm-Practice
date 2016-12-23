namespace ConsoleApplication
{

    public class RomanNumeralGenerator
    {
        public int numberLeft;
        public string displayString = "";
        public RomanNumeralGenerator(int inputNumber) {
            numberLeft = inputNumber;
            runner();
        }
        public void runner()
        {
            while (numberLeft > 0) {
                numberLeft = converter(numberLeft);
            }
        }

        public int converter(int inputNumber)
        {
            if (inputNumber >= 1000){
                displayString = displayString + 'M';
                inputNumber = inputNumber - 1000;
            }else if (inputNumber >= 900) {
                displayString = displayString + "CM";
                inputNumber = inputNumber - 900;
            }else if (inputNumber >= 500){
                displayString = displayString + 'D';
                inputNumber = inputNumber - 500;
            }else if (inputNumber >= 400) {
                displayString = displayString + "CD";
                inputNumber = inputNumber - 400;
            }else if (inputNumber >= 100){
                displayString = displayString + 'C';
                inputNumber = inputNumber - 100;
            }else if (inputNumber >= 90) {
                displayString = displayString + "XC";
                inputNumber = inputNumber - 90;
            }else if (inputNumber >= 50){
                displayString = displayString + 'L';
                inputNumber = inputNumber - 50;
            }else if (inputNumber >= 40) {
                displayString = displayString + "XL";
                inputNumber = inputNumber - 40;
            }else if (inputNumber >= 10) {
                displayString = displayString + 'X';
                inputNumber = inputNumber - 10;
            }else if (inputNumber == 9){
                displayString = displayString + "IX";
                inputNumber = inputNumber - 9;
            }
            else if (inputNumber >= 5) {
                displayString = displayString + 'V';
                inputNumber = inputNumber - 5;
            } else if (inputNumber >= 1) {
                displayString = displayString + "I";
                inputNumber = inputNumber - 1;
            } else {
                //Do nothing;
            }
            return inputNumber;
        }
    }
}