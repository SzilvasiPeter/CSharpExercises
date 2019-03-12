using System;
using System.Reflection;

namespace CSharp.Reflection
{
    class Test{}
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = Assembly.GetCallingAssembly().GetType("Test");
            var t = Activator.CreateInstance(type);
            System.Console.WriteLine(t.GetType());
        }
    }
}