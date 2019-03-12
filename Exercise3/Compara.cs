using System;
using System.Collections;

namespace CSharp.Exercise3
{
    public class Compara
    {
        public class ComparableClass : IComparable
        {
            public ComparableClass(int value)
            {
                this.Value = value;
            }

            public int Value { get; private set; }

            public int CompareTo(object obj)
            {
                if(obj is ComparableClass)
                {
                    ComparableClass c = (ComparableClass)obj;
                    return Value.CompareTo(c.Value);
                }
                else throw (new Exception("Not valid object"));
            }
        }

        public class ComparableClassComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                if(x is ComparableClass && y is ComparableClass)
                {
                    ComparableClass _x = (ComparableClass)x;
                    ComparableClass _y = (ComparableClass)y;

                    return _x.CompareTo(_y);
                }
                else throw(new Exception("Not valid parameter"));
            }
        }
    }
}