using System.Diagnostics;

namespace DelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client 1 - all
            //ProcessManager.ShowProcessList();
            // client 2 - by name
            //ProcessManager.ShowProcessList("S");
            // client 3 - by memory
            ProcessManager.ShowProcessList(100 * 1024 * 1024);

        }
    }

    public class ProcessManager
    {
        public static void ShowProcessList()
        {
            foreach (Process p in Process.GetProcesses())
            {
                Console.WriteLine(p.ProcessName);
            }
        }
        public static void ShowProcessList(string sw)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.StartsWith(sw))
                    Console.WriteLine(p.ProcessName);
            }
        }
        public static void ShowProcessList(long memSize)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.WorkingSet64 >= memSize)
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
}