using DungeonsOfDoom.Core.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Items
{
    public class Potion : Item
    {
        public Potion(string name, int bonus) : base(name, bonus)
        {
        }

        /// <summary>
        /// Adds Health bonus from item to Player.
        /// </summary>
        /// <param name="player">The player to add the bonus to.</param>
        public override void AddBonus(Player player)
        {
            player.Health += Bonus;
        }
    }
}
