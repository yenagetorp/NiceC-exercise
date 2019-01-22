using System;

namespace test
{
    enum Gender
    {
        Female,
        Male
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Mammal(Gender.Female, 10.5);
        }
    }

    abstract class Animal
    {
        public double Weight { get; set; }

        public Animal(double weight)
        {
            Weight = weight;
        }

        public Animal()
        {

        }
    }

    class Mammal : Animal
    {
        public Gender Gender { get; set; }

        public Mammal(Gender gender, double weight):base()
        {
            Gender = gender;
        }
    }
}
