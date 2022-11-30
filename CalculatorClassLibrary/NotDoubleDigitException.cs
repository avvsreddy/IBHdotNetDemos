namespace CalculatorClassLibrary
{
    public class NotDoubleDigitException : ApplicationException
    {
        public NotDoubleDigitException(string msg = null, Exception ex = null) : base(msg, ex)

        {

        }
    }
}
