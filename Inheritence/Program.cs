namespace CSharp.Inheritence
{
    abstract class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual void Eat()
        {
            System.Console.WriteLine("An animal is eating");
        }

        public abstract void Breathe();
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public new virtual void Eat()
        {
            System.Console.WriteLine("A dog eat a bone");
        }

        public override void Breathe()
        {
            System.Console.WriteLine("In and out");
        }
    }

    class Crocodile : Animal
    {
        public Crocodile(string name) : base(name)
        {

        }

        public override void Eat()
        {
            System.Console.WriteLine("A crocodile eat a man");
        }

        public override void Breathe()
        {
            System.Console.WriteLine("Out and in");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal[] animalArray = new Animal[2];
            Dog d = new Dog("Csipész");
            Crocodile c = new Crocodile("Krokk");

            animalArray[0] = new Dog("animal1");
            animalArray[1] = new Crocodile("animal2");
            d.Eat();
            c.Eat();

        }
    }
}