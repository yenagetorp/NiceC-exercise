using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
   public abstract class Character : Element, IAttackable
    {
        private int health;
        public int Health
        {
            get { return health; }
            set
            {
                if (value > MaxHealth)
                {
                    health = MaxHealth;
                }
                else
                    health = value;
            }
        }

        public int Strength { get; set; } //public tills vidare
        public int MaxHealth { get; set; }
        public string Name { get; }
        /// <summary>
        /// Create a new Character
        /// </summary>
        /// <param name="name">Name of character</param>
        /// <param name="health">Max and inital health of character</param>
        /// <param name="color">Console color of object</param>
        /// <param name="strength">Strength of character</param>
        public Character(string name, int health, ConsoleColor color, int strength) : base(color)
        {
            Name = name;
            MaxHealth = health;
            Health = health;
            Strength = strength;
        }
        /// <summary>
        /// Deals damage to <paramref name="opponent"/>
        /// </summary>
        /// <param name="opponent"></param>
        /// <returns>FightStats instance</returns>
        public virtual FightStats Fight(IAttackable opponent)
        {
            opponent.Health -= Strength;

            return new FightStats(Name, opponent.Name, Strength);
        }
    }

 
}
