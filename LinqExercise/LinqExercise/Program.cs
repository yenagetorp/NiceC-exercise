using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        static List<Person> people = File.ReadAllLines("C:\\Users\\Yen Agetorp\\Desktop\\names.csv")
                          .Distinct()//det här borde sortera efter en string instead of Person.
                          .Select(p => Person.FromCsv(p))       // .Select(s => Person.FromCsv(s)), s is a string parameter.
                          .OrderBy(p => p.Name)
                          .ToList();

        static void Main(string[] args)
        {
            // Console.WriteLine(people.Count());



            //CharacterMatch("AZ");
            //NamesDagMatch(new DateTime(2015, 03, 04));
            //ChractersAndMonthMatch("AB", new DateTime(2015, 12, 30));
            // SortByAlphabetMethod();
            // NameDaysIneachMonth();
            NameDaysIneachQuater();


        }

        private static void NameDaysIneachQuater()
        {
            int totalPeopleCount = 0;
            var q = people
                 .GroupBy(p => p.NameDay.Month)
                 .OrderBy(p => p.Key);
            foreach (var item in q)
            {
                totalPeopleCount += item.Count();
                if (item.Key == (int)Monthes.January || item.Key == (int)Monthes.February || item.Key ==(int) Monthes.March)
                {
                    int quater1 = item.Count();
                    Console.WriteLine($"Quter 1: {quater1}");
                }
                else
                {
                    Console.WriteLine();
                }
                //case (int)Monthes.April:
                //case (int)Monthes.May:
                //case (int)Monthes.June:
                //    {
                //        int quater2 = item.Count();
                //        Console.WriteLine($"Quter 2: {quater2}");
                //        break;
                //    }
                //case (int)Monthes.July:
                //case (int)Monthes.August:
                //case (int)Monthes.September:
                //    {
                //        int quater3 = item.Count();
                //        Console.WriteLine($"Quter 3: {quater3}");
                //        break;
                //    }
                //case (int)Monthes.October:
                //case (int)Monthes.November:
                //case (int)Monthes.December:
                //    {
                //        int quater4 = item.Count();
                //        Console.WriteLine($"Quter 4: {quater4}");
                //        break;
                //    }
                //default:
                //    {
                //        Console.WriteLine("Notset");break;
                //    }
            }
        }

    

    private static void NameDaysIneachMonth()
    {
        int totalPeopleCount = 0;
        var q = people
             .GroupBy(p => p.NameDay.Month)
             .OrderBy(p => p.Key);

        Console.WriteLine(q.Count());
        foreach (var item in q)
        {
            totalPeopleCount += item.Count();

            switch (item.Key)
            {

                case (int)Monthes.January:

                    Console.WriteLine($"{Monthes.January}: {item.Count()}"); break;
                case (int)Monthes.February:

                    Console.WriteLine($"{Monthes.February}: {item.Count()}"); break;
                case (int)Monthes.March:

                    Console.WriteLine($"{Monthes.January}: {item.Count()}"); break;
                case (int)Monthes.April:

                    Console.WriteLine($"{Monthes.April}: {item.Count()}"); break;
                case (int)Monthes.May:

                    Console.WriteLine($"{Monthes.May}: {item.Count()}"); break;
                case (int)Monthes.June:

                    Console.WriteLine($"{Monthes.June}: {item.Count()}"); break;
                case (int)Monthes.July:

                    Console.WriteLine($"{Monthes.July}: {item.Count()}"); break;
                case (int)Monthes.August:

                    Console.WriteLine($"{Monthes.August}: {item.Count()}"); break;
                case (int)Monthes.September:

                    Console.WriteLine($"{Monthes.September}: {item.Count()}"); break;
                case (int)Monthes.October:

                    Console.WriteLine($"{Monthes.October}: {item.Count()}"); break;
                case (int)Monthes.November:

                    Console.WriteLine($"{Monthes.November}: {item.Count()}"); break;
                case (int)Monthes.December:

                    Console.WriteLine($"{Monthes.December}: {item.Count()}"); break;
                case (int)Monthes.NotSet:
                    Console.WriteLine($"{Monthes.NotSet}: {item.Count()}"); break;
            }

        }
        Console.WriteLine($"The total people count:{totalPeopleCount}");

    }

    private static void SortByAlphabetMethod()
    {
        var q = people
            .GroupBy(p => p.Name[0])
            .Select(p => $"{p.Key}:\t {p.Count()}");
        foreach (var item in q)
        {
            Console.WriteLine(item);
        }
    }

    private static void ChractersAndMonthMatch(string chracters, DateTime dt)
    {
        string s = chracters.ToLower();
        var q = people.Where(p => p.Name.ToLower().StartsWith(s) && p.NameDay.Month.Equals(dt.Month));
        foreach (var item in q)
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine($"People whos name begin with the same letters and has the same name month: {q.Count()}");
    }

    private static void CharacterMatch(string characters)
    {
        string s = characters.ToLower();
        IEnumerable<Person> p = people
                                .Where(q => q.Name.ToLower().StartsWith(s));
        foreach (var item in p)
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine($"The number of people whos name begins with 'an':{p.Count()}");
    }


    private static void NamesDagMatch(DateTime dt)
    {
        IEnumerable<Person> q = people
            .Where(s => s.NameDay.Equals(dt));

        Console.WriteLine($"the names day match:{ q.Count()}");
    }



}
}
