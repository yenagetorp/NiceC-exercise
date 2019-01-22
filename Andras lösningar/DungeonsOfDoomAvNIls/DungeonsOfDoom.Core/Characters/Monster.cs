using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsOfDoom.Core;

namespace DungeonsOfDoom.Core.Characters
{
    /// <summary>
    /// Make a monster
    /// </summary>
    /// <seealso cref="DungeonsOfDoom.Core.Characters.Character" />
    /// <seealso cref="DungeonsOfDoom.Core.ICollectable" />
    public abstract class Monster : Character, ICollectable
    {
        public Monster(int health, string name, int attack, int defense, string[] battleShouts) : base(health, name, attack, defense, battleShouts)
        {
            NumberOfMonsters++;
        }

        /// <summary>
        /// Gets or sets the total number of monsters. 
        /// </summary>
        public static int NumberOfMonsters { get; set; }
    }
}