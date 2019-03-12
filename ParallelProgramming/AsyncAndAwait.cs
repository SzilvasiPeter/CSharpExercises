using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class AsyncAndAwait
    {
        static async void DoOperations(){
            var result = await Task<string>.Factory.StartNew(
                () => ReallyLongOperation()
            );

            System.Console.WriteLine("The result: {0}", result);
        }

        static string ReallyLongOperation()
        {
            Thread.Sleep(2000);
            return "Done";    
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Before operation...");
            DoOperations();
            System.Console.WriteLine("After operation...");

            Console.ReadKey();
        }
    }
}