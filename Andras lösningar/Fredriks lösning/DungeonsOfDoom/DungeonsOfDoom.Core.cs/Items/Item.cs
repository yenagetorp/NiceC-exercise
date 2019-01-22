using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core
{
    public abstract class Item : Element, ILootable
    {
        /// <summary>
        /// Initialize an item instance
        /// </summary>
        /// <param name="name">Name of item</param>
        public Item(string name) : base(ConsoleColor.Yellow)
        {
            Name = name;
        }

        /// <summary>
        /// Adds instance to <paramref name="player"/> inventory
        /// </summary>
        /// <param name="player">Specific players inventory</param>
        public abstract void Pickup(Player player);

        public string Name { get; protected set; }
    }
}
