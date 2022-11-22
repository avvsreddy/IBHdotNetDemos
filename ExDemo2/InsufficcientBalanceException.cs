namespace ExDemo2
{
    class InsufficcientBalanceException : ApplicationException
    {
        public InsufficcientBalanceException(string msg = null, Exception ex = null) : base(msg, ex)
        {

        }
    }
}