using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

namespace CSharp.ParallelProgramming
{
    public class TaskParallel
    {
        static public double[,] GenerateMatrix(int size)
        {
            double[,] matrix = new double[size, size];
            Random r = new Random();

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    matrix[i, j] = r.Next(0, 100);
                }
            }

            return matrix;
        }
        // static void Main(string[] args)
        // {
        //     int size = 100;

        //     double[,] a = GenerateMatrix(size);
        //     double[,] b = GenerateMatrix(size);
        //     double[,] c = new double[size, size];

        //     Stopwatch sw = new Stopwatch();
        //     sw.Start();

        //     for(int i = 0; i < size; i++){
        //         for(int j = 0; j < size; j++){
        //             double v = 0;
        //             for(int k = 0; k < size; k++){
        //                 v += a[i, k] * b[k, j];
        //             }
        //             c[i, j] = v;
        //         }
        //     }

        //     sw.Stop();

        //     System.Console.WriteLine("The cycle times useage: {0} ms", sw.ElapsedMilliseconds);

        //     c = new double[size, size];
        //     sw.Reset();

        //     sw.Start();

        //     Parallel.For(0, size, (i) =>
        //     {
        //         for(int j = 0; j < size; j++){
        //             double v = 0;
        //             for(int k = 0; k < size; k++){
        //                 v += a[i, k] * b[k, j];
        //             }
        //             c[i, j] = v;
        //         }
        //     });

        //     sw.Stop();

        //     System.Console.WriteLine("The cycle time useage: {0} ms", sw.ElapsedMilliseconds);
        //     // int[] array = Enumerable.Range(0, 10000).ToArray<int>();
        //     // Stopwatch sw = new Stopwatch();

        //     // long result1 = 0;
        //     // long result2 = 0;

        //     // Parallel.For(0, array.Length, (i) => System.Console.WriteLine(array[i]));
        //     // sw.Stop();

        //     // result1 = sw.ElapsedMilliseconds;

        //     // sw.Reset();
        //     // sw.Start();

        //     // for(int i = 0; i < array.Length; ++i){
        //     //     System.Console.WriteLine(array[i]);
        //     // }

        //     // sw.Stop();

        //     // result2 = sw.ElapsedMilliseconds;

        //     // System.Console.WriteLine("First cycle time: {0} ms", result1);
        //     // System.Console.WriteLine("Second cycle time: {0} ms", result2);
        // }
    }
}