using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Characters
{
    public abstract class Character
    {
        public Character(int health, string name, int attack, int defense, string[] battleShouts)
        {
            Health = health;
            Name = name;
            Power = attack;
            Defense = defense;
            BattleShouts = battleShouts;
           
        }
        public int Health { get; set; }
        public int Power { get; set; }
        public int Defense { get; set; }

        public string Name { get; }

        public string[] BattleShouts { get; }

        /// <summary>
        /// Attacks an opponent. Damage is calculated by Attacker.Power - Opponent.Defense
        /// </summary>
        /// <param name="opponent">Target of attack</param>
        /// <returns></returns>
        public virtual int Attack(Character opponent)
        {
            int damage = Math.Max(0, Power - opponent.Defense);
            opponent.Health -= damage;
            return damage;
        }
    }
}
