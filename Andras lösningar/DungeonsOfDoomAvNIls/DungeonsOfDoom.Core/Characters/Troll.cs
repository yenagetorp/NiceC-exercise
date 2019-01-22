using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Characters
{
    public class Troll : Monster
    {
        /// <summary>
        /// Creates a more powerful monster Troll
        /// </summary>
        /// <seealso cref="DungeonsOfDoom.Core.Characters.Monster" />
        public Troll () : base(25, "Troll", 10, 7, new string[3] { "Troll smash", "Youu die!!", "Nom Nom Nom" })
        {
        }
        /// <summary>
        /// Attacks an opponent. Damage is calculated by 2 * Attack.Power - Opponent.Defense
        /// </summary>
        /// <param name="opponent">Target of attack</param>
        /// <returns></returns>
        public override int Attack(Character opponent)
        {
            int damage = Math.Max(0, 2 * Power - opponent.Defense);
            opponent.Health -= damage;

            return damage;
        }
    }
}
