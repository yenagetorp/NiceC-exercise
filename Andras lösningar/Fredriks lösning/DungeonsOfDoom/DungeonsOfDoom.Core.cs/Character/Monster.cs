using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core
{ 
    public abstract class Monster : Character, ILootable
    {
        static public int MonsterCount { get; set; }
        /// <summary>
        /// Create a new Monster
        /// </summary>
        /// <param name="name">Name of character</param>
        /// <param name="health">Max and inital health of character</param>
        /// <param name="color">Console color of object</param>
        /// <param name="strength">Strength of character</param>
        public Monster(int health, string name, ConsoleColor color, int strength) : base(name, health, color, strength)
        {
            MonsterCount++;
        }

        /// <summary>
        /// Adds instance to <paramref name="player"/> inventory
        /// </summary>
        /// <param name="player">Specific players inventory</param>
        public void Pickup(Player player)
        {
            player.Inventory.Add(this);
        }
    }
}
