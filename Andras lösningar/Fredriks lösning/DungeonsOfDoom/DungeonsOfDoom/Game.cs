using DDUtils;
using System;
using DungeonsOfDoom.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Game
    {
        Player player;
        Room[,] world;
        const int WorldWidth = 20;
        const int WorldHeight = 5;

        public void Play()
        {
            CreatePlayer();
            do
            {
                ResetPlayerPosition();
                CreateWorld();

                do
                {
                    Console.Clear();
                    DisplayWorld();
                    DisplayStats();
                    AskForMovement();
                    RoomEvent();
                } while (player.Health > 0 && Monster.MonsterCount != 0);

            } while (player.Health > 0);


            GameOver();
        }

        private void ResetPlayerPosition()
        {
            player.X = 0;
            player.Y = 0;
        }

        private void RoomEvent()
        {
            Room room = world[player.X, player.Y];
            if (room.Chest != null) // INTE KLAR!!
            {
                Console.Clear();
                Console.WriteLine("You found a chest!");
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    DisplayFight(room.Chest, room.Chest.Fight(player));
                    Console.ReadKey();

                } while (room.Chest.Health > 0);

                room.Chest.Pickup(player);
                room.Chest = null;
            }
            else if (room.Item != null)
            {
                room.Item.Pickup(player);
                room.Item = null;
            }
            else if (room.Monster != null)
            {
                Console.Clear();
                Console.WriteLine("FIGHT!!!");
                Console.ReadKey(true);
                do
                {
                    Console.Clear();
                    DisplayFight(room.Monster, room.Monster.Fight(player));
                    Console.ReadKey(true);

                    if (player.Health > 0 && room.Monster.Health > 0)
                    {
                        Console.Clear();
                        DisplayFight(room.Monster, player.Fight(room.Monster));
                        Console.ReadKey(true);
                    }
                } while (room.Monster.Health > 0 && player.Health > 0);

                if (room.Monster.Health <= 0)
                {
                    room.Monster.Pickup(player);
                    room.Monster = null;
                    Monster.MonsterCount--;
                }
            }
        }

        private void DisplayFight(IAttackable monster, FightStats fightStats)
        {
            WriteColor($"{player.Name.PadRight(30, ' ')}{monster.Name}", ConsoleColor.Gray);
            Console.WriteLine();
            WriteColor($"{HealthBar(player).PadRight(30, ' ')}{HealthBar(monster)}", ConsoleColor.Green);
            Console.WriteLine();
            Console.WriteLine();
            if (fightStats.EventMessage == null)
                Console.WriteLine($"{fightStats.Attacker} dealt {fightStats.DamageDealt} damage to {fightStats.Defender}.");
            else
                Console.WriteLine(fightStats.EventMessage);
        }

        private string HealthBar(IAttackable character)
        {
            string bar = "";
            int percent = 10 * character.Health / character.MaxHealth;
            for (int i = 0; i < 10; i++)
            {
                if (i < percent)
                    bar += "\u2588";
                else
                    bar += "\u2592";
            }
            return bar;
        }

        private void CreatePlayer()
        {
            player = new Player(30, 0, 0, 5);
        }

        private void CreateWorld()
        {
            Monster.MonsterCount = 0;
            world = new Room[WorldWidth, WorldHeight];
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    int percentage = Utilities.Random(0, 100);
                    if (percentage < 5)
                        world[x, y].Monster = new Orc();
                    else if (percentage < 10)
                        world[x, y].Monster = new Skeleton();
                    else if (percentage < 15)
                        world[x, y].Item = new Consumable();
                    else if (percentage < 20)
                        world[x, y].Item = new Weapon();
                    else if (percentage < 23)
                        world[x, y].Chest = new Chest();
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
                        WriteColor("P", player.Color);
                    else if (room.Monster != null)
                        WriteColor("M", room.Monster.Color);
                    else if (room.Chest != null)
                        WriteColor("C", room.Chest.Color);
                    else if (room.Item != null)
                        WriteColor("I", room.Item.Color);
                    else
                        Console.Write("-");
                }
                Console.WriteLine();
            }
        }

        private void WriteColor(string text, ConsoleColor color)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = originalColor;
        }

        private void DisplayStats()
        {
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Strength: {player.Strength}");
            Console.WriteLine($"MonsterCount: {Monster.MonsterCount}");
            Console.WriteLine("Inventory:");
            foreach (var item in player.Inventory)
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

        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over...");
            Console.ReadKey();
            Play();
        }
    }
}
