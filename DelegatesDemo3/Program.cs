namespace DelegatesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.Deposit(5000);
            Console.WriteLine(acc1.Balance);
            acc1.Withdraw(1000);
            Console.WriteLine(acc1.Balance);
        }
    }

    class Account
    {
        public int Balance { get; private set; }

        public void Deposit(int amount)
        {
            Balance += amount;
            Notification.SendMail($"Account has been increased by {amount}");

        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
            // write a code send email
            Notification.SendMail($"Account has been decreased by {amount}");
        }
    } // OCP


    class Notification
    {
        public static void SendMail(string msg)
        {
            Console.WriteLine($"Mail: {msg}");
        }
    }
}