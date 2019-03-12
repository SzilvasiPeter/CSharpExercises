using System;

namespace CSharp.Generics
{
    public class Generics
    {
        class Stack<T> where T : struct // class, new(), ...
        {
            T[] t;
            int pointer;
            readonly int size;

            public Stack(int capacity)
            {
                t = new T[capacity];
                size = capacity;
                pointer = 0;
            }

            public void Push(T item)
            {
                if(pointer >= size){
                    throw (new StackOverflowException("Full..."));
                }

                t[pointer++] = item;
            }

            public object Pop()
            {
                if(pointer-- >= 0){
                    return t[pointer];
                }

                pointer = 0;
                throw (new InvalidOperationException("Empty..."));
            }
        }

        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>(10);

            for(int i = 0; i < 10; i++){
                s.Push(i);
            }

            for(int i = 0; i < 10; i++){
                System.Console.WriteLine(s.Pop());
            }
        }
    }
}