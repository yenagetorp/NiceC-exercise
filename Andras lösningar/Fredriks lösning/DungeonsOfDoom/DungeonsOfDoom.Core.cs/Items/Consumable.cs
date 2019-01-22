using DDUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public class Consumable : Item
    {
        public int HealthValue { get; }

        /// <summary>
        /// Initialize a consumable with a random Health value
        /// </summary>
        public Consumable() : base("Consumable")
        {
            HealthValue = Utilities.Random(1, 4);
        }

        /// <summary>
        /// Add this consumables <paramref name="HealthValue"/> to <paramref name="player"/>
        /// </summary>
        /// <param name="player">Add Health to this player</param>
        public override void Pickup(Player player)
        {
            player.Health += HealthValue;
        }
    }
}
