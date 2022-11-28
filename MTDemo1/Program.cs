﻿using System.Diagnostics;

namespace MTDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine($"Main in exe in thread :{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Running Seq...");
            Stopwatch sw = Stopwatch.StartNew();
            M1();
            M2();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("Running using Threads...");
            sw = Stopwatch.StartNew();
            ThreadStart ts1 = new ThreadStart(M1);
            Thread t1 = new Thread(ts1);
            t1.Start();

            Thread t2 = new Thread(M2);
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine("Running using Task - TPL");
            sw = Stopwatch.StartNew();
            Task tt1 = new Task(M1);
            tt1.Start();
            Task tt2 = new Task(M2);
            tt2.Start();
            tt1.Wait();
            tt2.Wait();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine("Running using Parallel - TPL");
            sw = Stopwatch.StartNew();
            Parallel.Invoke(M1, M2);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public static void M1()
        {
            //Console.WriteLine($"M1 in exe in thread :{Thread.CurrentThread.ManagedThreadId}");
            for (int i = 1; i <= 100; i++)
            {
                //Console.WriteLine($"M1: {i}");
                Thread.Sleep(100);
            }
        }

        public static void M2()
        {
            //Console.WriteLine($"M2 in exe in thread :{Thread.CurrentThread.ManagedThreadId}");
            for (int i = 1; i <= 100; i++)
            {
                //Console.WriteLine($"M2: {i}");
                Thread.Sleep(100);
            }
        }
    }
}