using System;
using System.Linq.Expressions;

namespace CSharp.Lambda
{
    public class LambdaExpression
    {
        public delegate int IntFunc(int x);
        public delegate int IntFunc2(int x, int y);

        static void Main(string[] args)
        {
            IntFunc func1 = (x) => (x * x);
            IntFunc2 func2 = (x, y) => (x * y);

            System.Console.WriteLine(func1(10));
            System.Console.WriteLine(func2(2, 5));

            Func<int, int> func3 = (x) => (x * x);
            Func<int, int, bool> func4 = (x, y) => (x > y);

            System.Console.WriteLine(func3(10));
            System.Console.WriteLine(func4(10, 5));

            Action<int> act = (x) => System.Console.WriteLine(x);
            act(10);

            Expression<Func<int, int, bool>> expression = (x, y) => (x > y);
            System.Console.WriteLine(expression.Compile().Invoke(10, 2));
        }
    }
}