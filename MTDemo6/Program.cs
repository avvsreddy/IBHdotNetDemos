using System.Collections.Concurrent;

namespace MTDemo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LargeObject lObj = new LargeObject();
            //lObj.Fill();
            //lObj.Fill();
            //Parallel.Invoke(lObj.Fill, lObj.Fill);
            //Thread t1 = new Thread(lObj.Fill);
            //Thread t2 = new Thread(lObj.Fill);
            //t1.Start();
            //t2.Start();

            //t1.Join();
            //t2.Join();

            Task t1 = new Task(lObj.Fill);
            Task t2 = new Task(lObj.Fill);
            t1.Start();
            t2.Start();

            t1.Wait();
            t2.Wait();

            Console.WriteLine(lObj.numbers.Count);
        }
    }

    public class LargeObject
    {
        //public Stack<int> numbers = new Stack<int>(); // mem
        public ConcurrentStack<int> numbers = new ConcurrentStack<int>();
        //[MethodImpl(MethodImplOptions.Synchronized)]
        public void Fill()
        {
            // fill some numbers into the stack
            for (int i = 1; i <= 1000000; i++)
            {
                //Monitor.Enter(this);
                //lock (this)
                //{
                numbers.Push(i);
                //}
                //Monitor.Exit(this);
            }
        }
    }
}