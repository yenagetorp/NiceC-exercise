using System;
using System.Collections.Generic;
using System.Linq;

namespace Repetitionmed_H
{
    class Program
    {
        static void Main(string[] args)
        {




            //Person håkan = new Person(56);
            //Person erica = new Person();
            //Tilldela age till erica.
            //erica.Age = 27;
            Person cengizhan = new Employee(13, "Cengizhan");
            Person mohanmed = new Employee(15, "Mohanmed");

            List<Person> people = new List<Person>()
            {
               // new Person(10, "Bo"),
                new Employee(30, "Li")
            };
            foreach (Person someperson in people)
            {
                someperson.CelebrateBirthday();
            }

            // Employee is person.
            Person x = new Employee(13, "ju");


            //Skapa list of Person.
            //List<Person> people = new List<Person>();
            //people.Add(mohanmed);  // add a person
            //people.Add(x);   // add a employee

            Employee employee = new Employee(x.Age, x.Name);

            if (employee.IsPayDay(WeekDay.Friday))
            {
                Console.WriteLine("Is Pay Day");
            }

            var keyboardkey = Console.ReadKey();
            if (keyboardkey.Key== ConsoleKey.C)
                Console.WriteLine("Du tryckte keyboard C.");
            TagType tagType = TagType.BoldTag;
            if(tagType == TagType.BoldTag)
            {
                Console.WriteLine("Bold");
            }
            else
            {
                Console.WriteLine("false;"); 
            }

            List<object> anything = new List<object>()
            {
                new Random(),
                10,
                new Employee(15, "Håkan")
            };

            Employee e = new Employee(35, "Anna");
            e.GenericMethod(10);
            e.GenericMethod(true);
            e.GenericMethod(people); //spelar ingen roll vilken type av parameter vi stoppa in.

            //* Delegate *//
            Func<int, int, bool> myMethod = IntComparison;
            Func<int, int, bool> lambda = (int a, int b)=>
            {
                return a < b;
            };



            int[] myIntegers = { 1, 3, 5, 2, 6 };

            //e.SelectionSort(myIntegers);
            // Utils.GenericSelectionSort(myIntegers, lambda);
             Utils.GenericSelectionSort(myIntegers,lambda);

            Utils.GenericSelectionSort(myIntegers, ( a,  b) =>  a < b); //en lambda a och b, compare a,b.






            //skapa en new collection
            Employee[] employees =
            {
                new Employee(10, "Bo"),
                new Employee(25, "Li"),
                new Employee(30, "An")
            };

            Utils.GenericSelectionSort(employees, (a, b) => a.Age < b.Age);
            //employees.GenericSelectionSort((a, b) => a.Age < b.Age);
             

            Utils.GenericSelectionSort(employees, (a, b) => string.Compare(a.Name, b.Name, true) < 0);
            employees.GenericSelectionSort((a, b) => string.Compare(a.Name, b.Name, true) < 0);


            var q = employees
                .Where(f => f.Age > 25)
                .OrderBy(f => f.Age)
                .Select(f => f.Name);
        }


        private static bool EmployeeComparison(Employee arg1, Employee arg2)
        {
            return string.Compare(arg1.Name, arg2.Name, true) < 0;  //Bokstäver comparison!
        }

        private static bool IntComparison(int arg1, int arg2)
        {
            return arg1 < arg2;           //lessThan returns true if arg1 < args2;
        }
	

	

    }
}
