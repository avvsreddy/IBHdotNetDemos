namespace ExDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account { AccNo = 111, Balance = 12000, IsActive = true, Pin = 1234 };
            AccoutManager aMgr = new AccoutManager();
            try
            {
                aMgr.Withdraw(acc, 1000, 1237);
            }
            catch (Exception ex) when (acc.Balance <= 0)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}