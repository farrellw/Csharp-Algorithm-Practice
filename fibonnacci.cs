namespace Practice
{
    public class Fibonacci
    {
        public static int Fibonaccer(int n) {
            if (n <= 2) {
                return 1;
            }
            return Fibonaccer(n-1) + Fibonaccer(n-2);
        }
    }
}