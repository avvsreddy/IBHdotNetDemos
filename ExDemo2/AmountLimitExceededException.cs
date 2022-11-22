namespace ExDemo2
{
    class AmountLimitExceededException : ApplicationException
    {
        public AmountLimitExceededException(string msg = null, Exception ex = null) : base(msg, ex)
        {

        }
    }
}