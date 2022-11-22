using NLog;

namespace ExceptionsWithNLogDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // install nuget package: nlog.extenstions.logging


            var logger = LogManager.GetCurrentClassLogger();
            try
            {
                int a = 10;
                int b = 0;
                var s = a / b;
                logger.Debug("In main method");
                Console.WriteLine("done");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.Message);
            }

        }
    }
}