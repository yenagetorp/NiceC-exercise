using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core
{
    public class Player : Character
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="health">Max and initial health of player</param>
        /// <param name="x">Sets the initial x-position of player</param>
        /// <param name="y">Sets the initial y-position of player</param>
        /// <param name="strength">Sets the initial strength of player</param>
        public Player(int health, int x, int y, int strength) : base("Player", health, ConsoleColor.White, strength)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public List<ILootable> Inventory { get; } = new List<ILootable>();
    }
}
