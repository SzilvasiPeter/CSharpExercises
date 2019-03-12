using System;
using System.Collections.Generic;
using static CSharp.Exercise3.Compara;
using static CSharp.Exercise3.Enumer;

namespace CSharp.Exercise3
{
    public class StartPoint
    {
        static void Main(string[] args)
        {
            AnimalContainer ac = new AnimalContainer();
            
            foreach(Animal animal in ac)
            {
                System.Console.WriteLine(animal.Name);
            }

            List<ComparableClass> list = new List<ComparableClass>();
            Random r = new Random();

            for(int i = 0; i < 10; i++){
                list.Add(new ComparableClass(r.Next(1000)));
            }

            foreach(ComparableClass c in list){
                System.Console.WriteLine("{0}", c.Value);
            }

            System.Console.WriteLine("\n Sorted list:");

            list.Sort();

            foreach(ComparableClass c in list){
                System.Console.WriteLine("{0}", c.Value);
            }

            Matrix matrix1 = new Matrix(2, 2);
            Matrix matrix2 = new Matrix(2, 2);
            for(int i = 0; i < matrix1.N; i++){
                for(int j = 0; j < matrix1.M; j++){
                    matrix1[i, j] = r.Next(10);
                    matrix2[i, j] = r.Next(10);
                }
            }
            System.Console.WriteLine(matrix1.ToString());
            System.Console.WriteLine(matrix2.ToString());

            System.Console.WriteLine(matrix1 + matrix2);
            
        }
    }

}