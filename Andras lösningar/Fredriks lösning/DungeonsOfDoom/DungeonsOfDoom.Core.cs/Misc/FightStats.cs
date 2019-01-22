using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public class FightStats
    {
        public int DamageDealt { get; set; }
        public string Attacker { get; set; }
        public string Defender { get; set; }
        public string EventMessage { get; set; }

        /// <summary>
        /// Default Fight-method
        /// </summary>
        /// <param name="attacker">Name of the attacker</param>
        /// <param name="defender">Name of the defender</param>
        /// <param name="damageDealt">Amount of damagel dealt</param>
        public FightStats(string attacker, string defender, int damageDealt)
        {
            Attacker = attacker;
            Defender = defender;
            DamageDealt = damageDealt;
        }

        /// <summary>
        /// Special Fight-method initializing the string <paramref name="specialEvent"/>
        /// </summary>
        /// <param name="attacker">Name of the attacker</param>
        /// <param name="defender">Name of the defender</param>
        /// <param name="specialEvent">Text of the special event to be displayed</param>
        public FightStats(string attacker, string defender, string specialEvent)
        {
            Attacker = attacker;
            Defender = defender;
            EventMessage = specialEvent;
        }

    }
}
