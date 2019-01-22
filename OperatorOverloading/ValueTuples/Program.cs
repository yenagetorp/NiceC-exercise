using System;

namespace ValueTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var what = GetIntString();
            var what1 = GetAgeName();
            Console.WriteLine(what1.age);

            var person = Tuple.Create(2, "Yen");
            Console.WriteLine(person.Item1);

            (int age, string name) = GetAgeName();
            Console.WriteLine(age);
        }


        /*Tuple requires at lest two values.*/
        static (int, string) GetIntString()
        {
            return (1, "Håkan");
        }

        static (int age, string Name) GetAgeName()
        {
            return (1, "Håkan");
        }
    }
}
