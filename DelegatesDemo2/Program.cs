using System.Diagnostics;

namespace DelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client 1 - all
            //ProcessManager.ShowProcessList(FilterNone);

            // Anonymous Delegates
            //ProcessManager.ShowProcessList(delegate
            //    {
            //        return true;
            //    });
            // client 2 - by name
            //ProcessManager.ShowProcessList("S");
            //ProcessManager.ShowProcessList(FilterByName);
            ProcessManager.ShowProcessList(delegate (Process p)
            {
                return p.ProcessName.StartsWith("S");
            });
            // client 3 - by memory
            //FilterDelegate filter = new FilterDelegate(FilterByMem);
            //ProcessManager.ShowProcessList(filter);

            // Anonymous Delegates

            ProcessManager.ShowProcessList(delegate (Process p)
            {
                return (p.WorkingSet64 >= 100 * 1024 * 1024);
            });

            // Lambda - Statement

            ProcessManager.ShowProcessList((Process p) =>
                {
                    return (p.WorkingSet64 >= 100 * 1024 * 1024);
                });

            // Lambda - Expression - Light Weight syntax for anonymous delegates

            ProcessManager.ShowProcessList(p => p.WorkingSet64 >= 100 * 1024 * 1024);


            // client 4
            //ProcessManager.ShowProcessList(FilterByThreads);

        }

        // client 1
        //public static bool FilterNone(Process p)
        //{
        //    return true;
        //}


        // client 2
        //public static bool FilterByName(Process p)
        //{
        //    return p.ProcessName.StartsWith("S");
        //}

        // client 3
        public static bool FilterByMem(Process p)
        {
            return (p.WorkingSet64 >= 100 * 1024 * 1024);
        }

        // client 4
        public static bool FilterByThreads(Process p)
        {
            return p.Threads.Count >= 50;
        }

    }


    public delegate bool FilterDelegate(Process p);
    public class ProcessManager
    {
        public static void ShowProcessList(FilterDelegate filter)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (filter.Invoke(p))
                    Console.WriteLine(p.ProcessName);
            }
        }

    }
}