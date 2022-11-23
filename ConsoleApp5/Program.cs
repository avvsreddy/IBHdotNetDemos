namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetData();
            Console.WriteLine("back in main");
            GetDataAsync();
            //Console.WriteLine(result);
            Console.WriteLine("back in main");
        }

        private static async Task GetDataAsync()
        {
            Console.WriteLine("calling bigmethodasync");
            var task = await BigMethodAsync();
            Console.WriteLine("doing something ");
            Console.WriteLine("doig something else");
            Console.WriteLine($"Got: {task}");
        }

        private static void GetData()
        {
            Console.WriteLine("calling bigmethod()");
            int data = BigMethod();

            Console.WriteLine($"Got: {data}");

        }

        public static Task<int> BigMethodAsync()
        {
            //Thread.Sleep(5000);
            return Task.Run<int>(() => { return 100; });
        }

        public static int BigMethod()
        {
            //Thread.Sleep(5000);
            return 100;
        }
    }

}