namespace DelegatesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.alert += Notification.SendMail; // delegate subscription
            acc1.alert += Notification.SendSMS; // delegate subscription
            acc1.Deposit(5000);
            Console.WriteLine(acc1.Balance);
            acc1.Withdraw(1000);
            Console.WriteLine(acc1.Balance);
        }
    }

    class Account
    {
        public int Balance { get; private set; }
        public AlertDelegate alert = null; // delegate instantiation
        public void Deposit(int amount)
        {
            Balance += amount;
            //Notification.SendMail($"Account has been increased by {amount}");
            if (alert != null) // delegate invokation
                alert($"Account has been increased by {amount}");

        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
            // write a code send email
            //Notification.SendMail($"Account has been decreased by {amount}");
            if (alert != null)
                alert($"Account has been decreased by {amount}");
        }
    } // OCP

    // delegate declaration
    public delegate void AlertDelegate(string msg);
    class Notification
    {
        public static void SendMail(string msg)
        {
            Console.WriteLine($"Mail: {msg}");
        }
        public static void SendSMS(string msg)
        {
            Console.WriteLine($"SMS: {msg}");
        }
    }
}