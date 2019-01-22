using DungeonsOfDoom.Core.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Items
{
    public abstract class Item : ICollectable
    {
        public int Bonus { get; }
        public string Name { get; }

        public Item(string name, int bonus)
        {
            Name = name;
            Bonus = bonus;
        }

        /// <summary>
        /// Adds bonus from item to Player.
        /// </summary>
        /// <param name="player">The player to add the bonus to.</param>

        public abstract void AddBonus(Player player);
        
    }
}
