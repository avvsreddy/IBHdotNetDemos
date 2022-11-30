namespace CalculatorClassLibrary
{
    // BL code
    public class Calculator
    {
        // find the sum of two int numbers

        ICalculatorResultRepository repo = null;

        // Moq 

        public Calculator()
        {
            repo = new CalculatorResultFileRepository();
        }
        public Calculator(ICalculatorResultRepository repo)
        {
            this.repo = repo;
        }

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
            // only 2 digit numbers
            if (a < 9 || b < 9 || a > 99 || b > 99)
            {
                throw new NotDoubleDigitException("Provide only double digit numbers");
            }
            // save the result
            int result = a + b;
            //CalculatorResultFileRepository repo = new CalculatorResultFileRepository();

            repo.Save($"{a}+{b}={result}");
            return result;
        }




    }

    // DAL Code
    public class CalculatorResultFileRepository : ICalculatorResultRepository
    {
        public void Save(string result)
        {
            File.WriteAllText("e:\\calculatorresult\\result.txt", result);
        }
    }
}