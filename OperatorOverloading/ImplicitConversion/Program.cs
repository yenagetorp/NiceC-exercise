using System;

namespace ImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = Person.ConvertStringToPerson("Håkan; Johansson; 56");
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");


            Person person1 = "Håkan; Johansson; 60";
            Console.WriteLine($"{person1.FirstName} {person1.LastName} {person1.Age}");

            string somePerson = person1;
            Console.WriteLine(somePerson);
        }
    }
}
