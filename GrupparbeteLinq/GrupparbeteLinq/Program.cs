using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Person[]
            {
                new Person{Name = "Bo Håkansson", Age = 20, WorkPlaceId =1},
                new Person{Name = "Li Ganegård", Age = 30, WorkPlaceId =1},
                new Person{Name = "An Agetorp", Age = 40, WorkPlaceId =2},
                new Person{Name = "Susanne Svensson", Age=70,WorkPlaceId= 3},
                new Person{Name="Susanne Agetorp",Age= 25, WorkPlaceId= 2 }
            };

            var workPlaces = new WorkPlace[]
            {
                new WorkPlace{WorkPlaceId =1, CompanyName = "ICA"},
                new WorkPlace{WorkPlaceId =2, CompanyName = "Coop"},
                new WorkPlace{WorkPlaceId=3, CompanyName="Willys"}
            };
            Console.WriteLine("//*Q3 (a)*//");
            var p1 = people
                .Where(p => p.Age < 30)
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Age);
            foreach (var item in p1)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }

            Console.WriteLine("//*Q3 (a)*// genom extension");
            p1.Print(p => $"{p.Name} {p.Age}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("//*Q3 (b)*//");
            Console.WriteLine(people.Count(p => p.Age < 30));
            Console.WriteLine();
            Console.WriteLine("//*Q3 (c)*//");
            Console.WriteLine(people.Average(p => p.Age));
            Console.WriteLine();
            Console.WriteLine("//*Q3 (d)*//");
            var p3 = people.FirstOrDefault(p =>           //p.Name == "Ai");
            {
                if (p.Name == "Bo")
                    return true;
                else
                    return false;
            });
            if (p3 != null)
            {
                Console.WriteLine($"Person {p3.Name} show up!");
            }
            else
            {
                Console.WriteLine("Null, no person appears!");
            }
            Console.WriteLine();
            Console.WriteLine();
            //*Q3 (e)*//
            //int numberOfPeople;
            var p4 = workPlaces
                .Join(people, w => w.WorkPlaceId, p => p.WorkPlaceId, (w, p) => new
                {
                    CompanyName = w.CompanyName,
                    EmployeeName = p.Name

                });
            //this same as below//
            //var p4 = people
            //   .Join(workPlaces, c => c.WorkPlaceId, b => b.WorkPlaceId, (c, b) => new
            //   {
            //       Name = b.CompanyName,
            //       CompanyName = c.Name
            //   });
            foreach (var item in p4)
            {
                Console.WriteLine($"{item.EmployeeName} {item.CompanyName}");
            }
            p4.Print(p => $"{p.EmployeeName} {p.CompanyName}");
            //the same as:
            //foreach (var item in people)
            //{
            //    Console.WriteLine($"{item.Name} {workPlaces.Where(w=>w.WorkPlaceId==item.WorkPlaceId).Single().CompanyName}");
            //}      
            Console.WriteLine();
            Console.WriteLine();
            //*Q3 (f)*//
            var p5 = workPlaces.GroupJoin(people, w => w.WorkPlaceId, p => p.WorkPlaceId, (w, companyEmployees) => new
            {
                CompanyName = w.CompanyName,
                CompanyCount = companyEmployees.Count(),
            });
            foreach (var item in p5)
            {
                Console.WriteLine($"{item.CompanyName} {item.CompanyCount}");
            }

            Console.WriteLine();
            Console.WriteLine(" //*Q3 (f)*//");
            p5.Print(p => $"{p.CompanyName} {p.CompanyCount}");

            Console.WriteLine("//*Q3 (g)*//");
            var p6 = workPlaces.GroupJoin(people, w => w.WorkPlaceId, p => p.WorkPlaceId, (w, workers) => new
            {
                CompanyName = w.CompanyName,
                EmployeesNames = workers
            });

            foreach (var company in p6)
            {
                Console.WriteLine(company.CompanyName);
                foreach (var employee in company.EmployeesNames)
                {
                    Console.Write($"{employee.Name}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//*Q3 (g)*// genom extensions");

            p6.Print(p => $"{p.CompanyName}: \n{String.Join(' ', p.EmployeesNames)}");
           // p6.Print(p => p.CompanyName);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkPlaceId { get; set; }
    }

    class WorkPlace
    {
        public int WorkPlaceId { get; set; }
        public string CompanyName { get; set; }
    }


    //Utils class bruka vara static. static contains only static(public
    //static) methods. och static class nås genom Utils., not genom instanser.
    static class Extensions
    {
        public static void Print<T>(this IEnumerable<T> collectionToPrint)
        {
            Print(collectionToPrint, a => a.ToString());
        }
        public static void Print<T>(this IEnumerable<T> collectionToPrint, Func<T, string> convertItemToString)
        {
            foreach (var item in collectionToPrint)
            {
                Console.WriteLine(convertItemToString(item));
            }
        }

    }
}
