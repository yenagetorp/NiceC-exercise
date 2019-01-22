using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo
{
    class Program     //////////Dynamic binding ?????????????????????
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            animals.Add(new Cat());  //Type Substitution
            animals.Add(new Dog(10));
            foreach (var animal in animals)
            {
                 animal.Eat(new Grass(1)); //animal är en object. animal.Eat()
                //Console.WriteLine(animal.Weight);
                Console.WriteLine(animal);

            }
        }
    }
    //Add a calss that has interface 
    class Grass: IEdible
    {
        public Grass(double weight)
        {
            Weight = Weight;
        }

        public double Weight { get; }
    }

    interface IEdible
    {
         double Weight { get; }
         //void Foo();

    }
    abstract class Animal: Object, IEdible// innan animla constructor körs
    {
        public Animal(double weight) : base() //referear till base calssen 
        {
            Weight = weight;
        }
        public double Weight  { get; protected set; }
        //public double Weight { get; set; }
        //public double Weight { get; }

        void Foo()
        {
        }
        public virtual void Eat( IEdible edible)// virtual--- can be overwritable.
        {
            Weight += 0.5 * edible.Weight;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}";
        }

        public abstract void MakeSound();//calssen is abstarct, therefore we can write abstract here. Abstract means we have to override in our subcalsses.
        
    }

    class Cat : Animal
    {
        public Cat( ): base(5)
        {

        }
       
        public void purr(int volume)
        {
            Console.WriteLine($"{volume}");
        }
        public override string ToString()
        {
            // return base.ToString();
            return $"Cat:{ base.ToString()}";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Dog : Animal
    {
        public Dog(double weight): base(weight)
        {

        }
        public void Bark()
        {
            Console.WriteLine("Bark");
        }

        public override void Eat(IEdible edible)
        {
            Weight += 0.8 * edible.Weight;
        }

        public override string ToString()
        {
            // return base.ToString();
            return $"Dog:{ base.ToString()}";
        }

        // when we have override in base calss, means that e have to have override in the subclasses.

        public override void MakeSound() // 
        {
            Console.WriteLine("Woff!");
        }
    }
}
