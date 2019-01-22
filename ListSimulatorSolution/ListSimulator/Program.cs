using System;
//using System.Linq;
using System.Collections.Generic;

namespace ListSimulator
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            //people.Insert
            //people.Contains()
            //people.Find()
            //people.Clear();
            Collection<Person> myList = new Collection<Person>(8);

            Person p1 = new Person { FirstName = "Håkan", LastName = "Johansson", Age = 56 };
            Person p2 = new Person { FirstName = "Marilyn", LastName = "Johansson", Age = 42 };
            Person p3 = new Person { FirstName = "Kenneth", LastName = "Johansson", Age = 9 };
            Person p4 = new Person { FirstName = "Nathalie", LastName = "Johansson", Age = 12 };
            Person p5 = new Person { FirstName = "Calle", LastName = "Cula", Age = 21 };
            Person p6 = new Person { FirstName = "Carin", LastName = "Cula", Age = 32 };


            myList.Add(p1);
            myList.Add(p2);
            myList.Add(p3);
            myList.Add(p4);
            myList.Add(p5);
            myList.Add(p6);
            //myList.Remove(p6);

            if (myList.Contains(p6))
                Console.WriteLine(p6);

            Person x = myList.Find(p => p.LastName.ToLower() == "cula" && p.Age > 21);
            if(x != null)
                Console.WriteLine(x);

            myList.Clear();
            myList.Add(p1);

            myList.RemoveAt(0);
            myList.RemoveAt(myList.Count - 1);

            myList[myList.Count - 1] = new Person { FirstName = "Carl", LastName = "XVI Gustav", Age = 72 };
            Person p0 = myList[myList.Count - 1];
            Console.WriteLine(p0);
            Console.WriteLine();

            myList[2] = new Person { FirstName = "Silvia", LastName = "Bernadotte", Age = 75 };
            p0 = myList[2];
            Console.WriteLine(p0);
            Console.WriteLine();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            //var q = myList
            //    .Where(p => p.LastName.ToUpper() == "JOHANSSON");

            //Console.WriteLine();
            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
