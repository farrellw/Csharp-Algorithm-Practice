namespace Practice 
{
    public class BinarySearch {

        public static int searcher(int[] inputArray, int inputInt, int min, int max)
        {
            //check the halfway point index 
            int checkIndex = (min + max) / 2;
            if (inputArray[checkIndex] > inputInt) {
                return searcher(inputArray, inputInt, min, checkIndex);
            } else if (inputArray[checkIndex] < inputInt) {
                return searcher(inputArray, inputInt, checkIndex, max);
            } else {
                return checkIndex;
            }
        }

    }

}