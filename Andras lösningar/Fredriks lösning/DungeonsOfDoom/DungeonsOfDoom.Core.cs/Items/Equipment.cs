using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public abstract class Equipment : Item
    {   
        /// <summary>
        /// Initialize an instance with a name derived from specific Equipment
        /// </summary>
        /// <param name="name">Equipments name</param>
        public Equipment(string name) : base(name)
        {
        }

        /// <summary>
        /// Adds instance to <paramref name="player"/> inventory
        /// </summary>
        /// <param name="player">Specific players inventory</param>
        public override void Pickup(Player player)
        {
            player.Inventory.Add(this);
        }
    }
}
