using System.Runtime.Serialization;

namespace CalculatorClassLibrary
{
    [Serializable]
    public class NotPositiveNumbersException : ApplicationException
    {
        public NotPositiveNumbersException()
        {
        }

        public NotPositiveNumbersException(string? message) : base(message)
        {
        }

        public NotPositiveNumbersException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotPositiveNumbersException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}