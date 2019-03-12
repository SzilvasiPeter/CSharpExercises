using System;
using System.Diagnostics;
using System.Threading;

namespace CSharp.MultiThread
{
    public class MultiThread
    {
        public delegate int MyDelegate(int x);

        static int Square(int x)
        {
            System.Console.WriteLine("Thread-Id: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(100);
            return (x * x);
        }
        static void Main(string[] args)
        {
            MyDelegate d = Square;
            System.Console.WriteLine("Thread-Id: {0}", Thread.CurrentThread.ManagedThreadId);

            IAsyncResult iar = d.BeginInvoke(12, null, null);
            while(!iar.IsCompleted){
                System.Console.WriteLine("Blabla");
            }
            
            int result = d.EndInvoke(iar);
            System.Console.WriteLine(result);

            // Process[] processList = Process.GetProcesses(".");

            // foreach(Process process in processList){
            //     System.Console.WriteLine("PID: {0}, Process-name: {1}", process.Id, process.ProcessName);
            // }

            // Process cal = Process.Start("cal");
            // Thread.Sleep(5000);
            // cal.Kill();
             
        }
    }
}