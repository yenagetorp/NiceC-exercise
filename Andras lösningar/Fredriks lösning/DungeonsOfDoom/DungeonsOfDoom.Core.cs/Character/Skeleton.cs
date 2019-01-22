using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public class Skeleton : Monster
    {
        /// <summary>
        /// Creates a orc with base values
        /// </summary>
        public Skeleton() : base(5, "Skeleton", ConsoleColor.Gray, 3)
        {
        }

        /// <summary>
        /// Skeleton attacking <paramref name="opponent"/>
        /// </summary>
        /// <param name="opponent">Opponent to be attacked</param>
        /// <returns>FightStats instance</returns>
        public override FightStats Fight(IAttackable opponent)
        {
            if (opponent.Strength / 2 > Strength)
            {
                Health = 0;
                return new FightStats(Name, opponent.Name, "Skeleton crumbled under the pressure of your strength...");
            }

            return base.Fight(opponent);

        }
    }
}
