using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Övn24
{
    internal class Program
    {
        private const string Path =
            @"C:\\Users\\Yen Agetorp\\Desktop\\names.csv";

        private static List<Person> people;

        private static void Main(string[] args)
        {
            GetAllNameDays();
           //FindNamesStatringWith("AN");
            //NamesHavingNameDay(new DateTime(2015, 06, 14));
            //NamesStartingWithHavingNameDay("AN", 12);
            //AlphabetMethod();
            NameDaysInEachMonth();
            //NameDaysInEachQuarter();
            //MostNameDayDates(5);
        }

        private static void MostNameDayDates(int numDays)
        {
            var q = people
                .GroupBy(p => p.NameDay)
                .OrderByDescending(d => d.Count())
                .Take(numDays)
                .OrderBy(x => x.Key);

            foreach (var item in q)
                Console.WriteLine($"{item.Key.ToShortDateString()}: {item.Count()} personer");
        }

        private static void AlphabetMethod()
        {
            int peopleCount = 0;

            var q = people
                .GroupBy(p => p.Name[0])
                .Select(p => $"{p.Key}: {p.Count()}")
                .OrderBy(s => s);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Totalt: {peopleCount} personer.");
        }

        private static void NameDaysInEachMonth()
        {
            int peopleCount = 0;

            var q = people
                .GroupBy(p => p.NameDay.Month)
                .OrderBy(p => p.Key);

            foreach (var item in q)
            {
                peopleCount += item.Count();
                string monthName = MonthName(item.Key) + ":";
                monthName = (monthName.Length > 7) ? monthName += "\t" : monthName += "\t\t";
                Console.WriteLine($"{monthName}{item.Count()}");
            }

            Console.WriteLine();
            Console.WriteLine($"Totalt: {peopleCount} personer.");

            string MonthName(int monthNo)
            {
                switch (monthNo)
                {
                    case 1:
                        return "januari";
                    case 2:
                        return "februari";
                    case 3:
                        return "mars";
                    case 4:
                        return "april";
                    case 5:
                        return "maj";
                    case 6:
                        return "juni";
                    case 7:
                        return "juli";
                    case 8:
                        return "augusti";
                    case 9:
                        return "september";
                    case 10:
                        return "oktober";
                    case 11:
                        return "november";
                    case 12:
                        return "december";
                    default:
                        return "N/A";
                }
            }
        }

        private static void NameDaysInEachQuarter()
        {
            int peopleCount = 0;

            var q = people
                .GroupBy(p => Quarter(p.NameDay.Month))
                .OrderBy(p => p.Key);

            foreach (var item in q)
            {
                peopleCount += item.Count();
                string quarterName = QuarterName(item.Key) + ":";
                quarterName = (quarterName.Length > 7) ? quarterName += "\t" : quarterName += "\t\t";
                Console.WriteLine($"{quarterName}{item.Count()}");
            }

            Console.WriteLine();
            Console.WriteLine($"Totalt: {peopleCount} personer.");

            string QuarterName(int quarter)
            {
                switch (quarter)
                {
                    case 1:
                        return "Quater 1";
                    case 2:
                        return "Quater 2";
                    case 3:
                        return "Quater 3";
                    case 4:
                        return "Quater 4";
                    default:
                        return "N/A";
                }
            }

            int Quarter(int month)
            {
                if (month >= 1 && month <= 3) return 1;
                else
                    if (month >= 4 && month <= 6) return 2;
                else
                    if (month >= 7 && month <= 9) return 3;
                else
                    if (month >= 10 && month <= 12) return 4;
                else
                    return 0;
            }
        }

        private static void NamesStartingWithHavingNameDay(string s, int monthNo)
        {
            s = s.ToLower();

            IEnumerable<Person> q = people
                .Where(p => p.Name.ToLower().StartsWith(s) && p.NameDay.Month == monthNo)
                .OrderBy(p => p.Name);

            foreach (Person item in q)
                Console.WriteLine(item);
        }

        private static void GetAllNameDays()
        {
            people = new List<Person>(2048);

            foreach (string item in File.ReadLines(Path, System.Text.Encoding.UTF7).Distinct())
                people.Add(item);

            Console.WriteLine($"Total number of rows: {people.Count}");
        }

        private static void FindNamesStatringWith(string s)
        {
            s = s.ToLower();

            IEnumerable<Person> q = people
                .Where(p => p.Name.ToLower().StartsWith(s))
                .OrderBy(p => p.Name);

            foreach (Person item in q)
            {
                Console.WriteLine(item);
            }
        }

        private static void NamesHavingNameDay(DateTime dt)
        {
            var q = people
                .Where(p => p.NameDay.Equals(dt))
                .OrderBy(p => p.Name);
                

            Console.WriteLine($"the names day match:{ q.Count()}");
            foreach (Person item in q)
                Console.WriteLine(item.Name);
        }
    }
}
