using DungeonsOfDoom.Core.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Items
{
    public class Weapon : Item
    {
        public Weapon(string name, int bonus) : base(name, bonus)
        {
            
        }

        /// <summary>
        /// Adds Power bonus from item to Player.
        /// </summary>
        /// <param name="player">The player to add the bonus to.</param>
        public override void AddBonus(Player player)
        {
            player.Power += Bonus;
        }
    }
}
