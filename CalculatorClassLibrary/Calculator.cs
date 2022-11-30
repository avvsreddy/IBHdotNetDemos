namespace CalculatorClassLibrary
{
    public class Calculator
    {
        // find the sum of two int numbers


        // only 2 digit numbers

        public int Sum(int a, int b)
        {
            // only even numbers
            if (a % 2 != 0 || b % 2 != 0)
            {
                throw new NotEvenNumbersException("Provide only even numbers");
            }
            // only +ve
            if (a < 0 || b < 0)
            {
                throw new NotPositiveNumbersException("Provide only +ve numbers");
            }
            return a + b;
        }

    }
}