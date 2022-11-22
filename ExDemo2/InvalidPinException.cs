namespace ExDemo2
{
    class InvalidPinException : ApplicationException
    {
        public InvalidPinException(string msg = null, Exception ex = null) : base(msg, ex)
        {

        }
    }
}