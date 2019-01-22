using System;
using System.Linq;

namespace CheckPoint03
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardGames = new BoardGame[]
            {
                new BoardGame{Name= "Risk", PlayerCount = 6},
                new BoardGame{Name= "Chess", PlayerCount = 2},
                new BoardGame{Name= "Blokus", PlayerCount = 4}
            };
            Console.WriteLine("//* Q(c) *//");
            var p1 = boardGames
                .Where(p => p.PlayerCount > 3);
            foreach (var name in p1)
            {
                Console.WriteLine($"{name.Name} {name.PlayerCount}");
            }
            Console.WriteLine("//* Q(c) *// genom extension method");
            p1.Print(p => $"{p.Name} {p.PlayerCount}");

            Console.WriteLine();
            Console.WriteLine("//* Q(d) *//");
            var p2 = boardGames
                .Where(p => p.Name.Length > 4)
                .OrderBy(p => p.Name);
            foreach (var name in p2)
            {
                Console.WriteLine($"Name:{name.Name}   Name Length:{name.Name.Length} ");
            }
            Console.WriteLine("//* Q(c) *// genom extension method");
            p2.Print(p => $"Name:{p.Name}   Name Length:{p.Name.Length} ");

            Console.WriteLine();
            Console.WriteLine("//* Q(e) *//");
            var p3 = boardGames
                .Count(p => p.Name.Length > 4);
            Console.WriteLine($"Antalet spel: {p3}");

            Console.WriteLine();
            Console.WriteLine("//* Q(f) *//");
            var p4 = boardGames
                .Average(p => p.PlayerCount);
            Console.WriteLine($"Genomsnittliga spel: {p4}");
        }
    }
}
