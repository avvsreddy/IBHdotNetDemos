namespace ExDemo2
{
    class AccountNotActiveException : ApplicationException
    {
        public AccountNotActiveException(string msg = null, Exception ex = null) : base(msg, ex)
        {

        }
    }
}