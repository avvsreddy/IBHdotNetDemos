namespace MTDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            Task tt1 = new Task(M1);
            Parallel.Invoke(M1);

            Thread t2 = new Thread(M2);//error
        }


        static void M1() { }
        static void M2(int a) { }
        static int M3() { retrun 1; }
        static int M4(int a) { return a; }
    }
}