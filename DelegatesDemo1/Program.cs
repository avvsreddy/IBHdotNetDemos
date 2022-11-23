namespace DelegatesDemo1
{

    //class MyDelegate : Delegate
    //{

    //}

    delegate void MyDelegate(string abc);  //step 1: delegate declaration

    internal class Program
    {
        static void Main(string[] args)
        {
            //Greeting("Good Morning!");
            //Delegate d = new Delegate();
            // Step 2 & 3: Delegate Instantiation and Initialization
            MyDelegate d = new MyDelegate(Greeting);
            // subscribe
            Program p = new Program();
            d += p.Hello;
            // unsubscription
            d -= Greeting;
            // Step 4: Invoke
            //d.Invoke("hello");
            d("another way");
        }

        static void Greeting(string msg)
        {
            Console.WriteLine($"Greeting: {msg}");
        }

        public void Hello(string msg)
        {
            Console.WriteLine($"Hello: {msg}");
        }
    }
}