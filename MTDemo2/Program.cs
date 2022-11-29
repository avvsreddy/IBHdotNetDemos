namespace MTDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            Task tt1 = new Task(M1);
            Parallel.Invoke(M1);

            //Thread t2 = new Thread(M2);//error
            Thread t2 = new Thread(() => { M2(100); });
            Task tt2 = new Task(() => { M2(1); });

            //Thread t3 = new Thread(M3);
            Task<int> tt3 = new Task<int>(M3);
            tt3.Start();
            int result = tt3.Result;

            Task<int> tt4 = new Task<int>(() => { return M4(100); });
        }


        static void M1() { }
        static void M2(int a) { }
        static int M3() { return 1; }
        static int M4(int a) { return a; }
    }
}