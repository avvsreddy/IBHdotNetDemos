namespace MTDemo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"No. Cores :{Environment.ProcessorCount}");
            MTDemo();
        }

        static void MTDemo()
        {
            ParallelOptions opt = new ParallelOptions();
            opt.MaxDegreeOfParallelism = Environment.ProcessorCount / 2;
            Parallel.For(1, 100, opt, x =>
            {
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            });
        }
    }
}