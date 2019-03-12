using System.Collections;

namespace CSharp.Exercise3
{
    public class Enumer
    {
        public interface IEnumerable
        {
            IEnumarator GetEnumerator();
        }

        public interface IEnumarator
        {
            bool MoveNext();
            void Reset();

            object Current{ get; }
        }

        public class Animal
        {
            public string Name { get; private set; }
            public Animal(string name)
            {
                this.Name = name;
            }
        }

        public class AnimalContainer : IEnumerable, IEnumarator
        {
            private ArrayList container = new ArrayList();
            private int currPosition = -1;

            public AnimalContainer()
            {
                container.Add(new Animal("Labrador"));
                container.Add(new Animal("Golden Retriver"));
                container.Add(new Animal("Border Coli"));
            }

            public object Current
            {
                get { return container[currPosition]; }
            }
            public bool MoveNext()
            {
                return (++currPosition < container.Count);
            }

            public void Reset()
            {
                currPosition = -1;
            }

            public IEnumarator GetEnumerator()
            {
                return (IEnumarator)this;
            }
        }
    }
}