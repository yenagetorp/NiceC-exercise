using DungeonsOfDoom.Core;
using DungeonsOfDoom.Core.Characters;
using DungeonsOfDoom.Core.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utils;

namespace DungeonsOfDoom
{
    class Game
    {
        Player player;
        Room[,] world;
        List<Item> items;
        List<Spell> spells;
        const int worldSizeX = 20;
        const int worldSizeY = 5;

        public void Play()
        {
            items = new List<Item>
            {
                new Weapon("Sword of a Thousand Cuts", 2),
                new Armour("Helmet of Polished Metal", 1),
                new Potion("Health Potion", 5),
                new Weapon("Battle-Worn Axe", 1),
                new Armour("Shield", 2),
                new Potion("Large Health potion", 10),
                new Weapon("Murderous Dagger", 3),
                new Armour("Thor's Breastplate", 7),
                new Potion("Insignificant Health Potion", 1),
                new Weapon("Poisoned Arrow", 5)
            };

            spells = new List<Spell>()
            {
                new Spell((c, o) => 
                {
                    // Fireball (ignores Armor)
                    int damage = RandomUtil.GetRandomValue(10 + 1);
                    o.Health -= damage;
                    return damage;
                }),
                new Spell((c, o) =>
                {
                    // Drain
                    int damage = RandomUtil.GetRandomValue(10 + 1);
                    c.Health += damage;
                    o.Health -= damage;
                    return damage;
                }),
            };

            CreatePlayer();
            CreateWorld();

            //PlayIntro();

            do
            {
                Console.Clear();
                DisplayWorld();
                DisplayStats();
                AskForMovement();
                CheckRoom();
            } while (player.Health > 0 && Monster.NumberOfMonsters > 0);

            if (player.Health > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("You win!!!!");
            }
            else
                GameOver();
        }

        private void PlayIntro()
        { 
            Console.Clear();

            AnimatedWrite($"Congratulations {player.Name}, for you have arrived at a place of wonder.", true);

            Thread.Sleep(300);

            AnimatedWrite("Here awaits might and magic, defeat and victory, life and death.", true);

            Thread.Sleep(300);

            AnimatedWrite("Are you prepared to put your finest skills to the ultimate test?", true);

            Console.WriteLine();

            Thread.Sleep(500);

            AnimatedWrite("Welcome to ", false);
            AnimatedWrite("DUNGEONS of DOOM!", true, 250);

            Thread.Sleep(1000);

            Console.WriteLine();

            AnimatedWrite("Press any key to start your adventure...", true);

            Console.ReadKey();
        }

        private void CreatePlayer()
        {
            Console.WriteLine("Enter player name...");

            string name = Console.ReadLine();
            player = new Player(30, 0, 0, name);
        }

        private void CreateWorld()
        {
            world = new Room[worldSizeX, worldSizeY];
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    if (RandomUtil.CheckPercent(2))
                        world[x, y].Monster = new Troll();
                    else if (RandomUtil.CheckPercent(5))
                        world[x, y].Monster = new Skeleton();
                    else if (RandomUtil.CheckPercent(8))
                        world[x, y].Monster = new Wizard(spells);
                    else if (RandomUtil.CheckPercent(10))
                        world[x, y].Item = items[RandomUtil.GetIndex(items.Count)];
                }
            }
        }

        private void DisplayWorld()
        {
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    Room room = world[x, y];
                    if (player.X == x && player.Y == y)
                        WriteColor("\u2665", ConsoleColor.Cyan);
                    else if (room.Monster != null)
                        WriteColor("!", ConsoleColor.Red);
                    else if (room.Item != null)
                        WriteColor("\u2666", ConsoleColor.Green);
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private void WriteColor(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ResetColor();
        }

        private void DisplayStats()
        {
            Console.WriteLine($" ");
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Attack: {player.Power}");
            Console.WriteLine($"Defense: {player.Defense}");

            foreach (var item in player.BackPack)
            {
                Console.WriteLine(item.Name);
            }
        }

        private void AskForMovement()
        {
            int newX = player.X;
            int newY = player.Y;
            bool isValidKey = true;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                default: isValidKey = false; break;
            }

            if (isValidKey &&
                newX >= 0 && newX < world.GetLength(0) &&
                newY >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;

            }
        }

        private void CheckRoom()
        {
            Room room = world[player.X, player.Y];
            Monster monster = room.Monster;
            Item item = room.Item;

            if (item != null)
            {
                PickUpItem(room, item);
            }
            if (monster != null)
            {
                Fight(monster, room);
            }


        }

        private void PickUpItem(Room room, Item item)
        {
            player.BackPack.Add(item);
            item.AddBonus(player);
            room.Item = null;
        }

        private void Fight(Monster monster, Room room)
        {
            Console.WriteLine();

            Console.WriteLine($"{player.Name} shouts at {monster.Name}: {player.BattleShouts[RandomUtil.GetIndex(player.BattleShouts.Length)]}");

            int damage = player.Attack(monster);
            Console.WriteLine($"{player.Name} hits {monster.Name} for {damage} damage.");

            if (monster.Health <= 0)
            {
                player.BackPack.Add(monster);
                Console.WriteLine($"{player.Name} has slain {monster.Name}!");
                room.Monster = null;
                Monster.NumberOfMonsters--;
            }
            else
            {
                Console.WriteLine($"{monster.Name} shouts at {player.Name}: {monster.BattleShouts[RandomUtil.GetIndex(monster.BattleShouts.Length)]}");
                damage = monster.Attack(player);
                Console.WriteLine($"{monster.Name} hits {player.Name} for {damage} damage.");
            }

            Console.ReadKey();

        }

        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over...");
            Console.ReadKey();
            Play();
        }

        private void AnimatedWrite(string msg, bool newline, int speed = 50)
        {
            foreach (var character in msg)
            {
                Console.Write(character);
                Thread.Sleep(speed);
            }

            if (newline)
                Console.WriteLine();
        }
    }
}
