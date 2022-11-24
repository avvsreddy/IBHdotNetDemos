namespace ContactManagement.DataAccess.Exceptions
{
    public class ContactManagementException : ApplicationException
    {
        public ContactManagementException(string msg = null, Exception innerEx = null) : base(msg, innerEx)
        {

        }
    }
}
