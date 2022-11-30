namespace DelegatesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.alert += Notification.SendMail; // delegate subscription
            acc1.alert += Notification.SendSMS; // delegate subscription
            acc1.alert += NewNotification.WhatsApp;
            //acc1.Subscribe(Notification.SendMail);
            //acc1.Subscribe(NewNotification.WhatsApp);

            //acc1.alert("Your account has been increased by $99999999999999");
            //acc1.Deposit(5000);
            Console.WriteLine(acc1.Balance);
            //acc1.Withdraw(1000);
            Console.WriteLine(acc1.Balance);
        }
    }

    class Account // SRP
    {
        public int Balance { get; private set; }
        public event AlertDelegate alert = null; // delegate instantiation

        //public void Subscribe(AlertDelegate alert)
        //{
        //    this.alert += alert;
        //}

        //public void Unsubscribe(AlertDelegate alert)
        //{
        //    this.alert -= alert;
        //}
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


    class NewNotification
    {
        public static void WhatsApp(string msg)
        {
            Console.WriteLine($"WhatsApp: {msg}");
        }
    }
}