namespace CalculatorClassLibrary
{
    public class NotEvenNumbersException : ApplicationException
    {
        public NotEvenNumbersException(string msg = null, Exception innerExp = null) : base(msg, innerExp)
        {

        }
    }
}
