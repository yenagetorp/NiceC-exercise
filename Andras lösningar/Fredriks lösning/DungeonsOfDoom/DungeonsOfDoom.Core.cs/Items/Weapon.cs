using DDUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public class Weapon : Equipment
    {

        public string Condition { get; }
        public string WeaponType { get; }
        public int StrengthValue { get; private set; }

        /// <summary>
        /// Initialize an instance of <c>Weapon</c>
        /// </summary>
        public Weapon() : base("Weapon")
        {
            WeaponType = RandomWeapon();
            Condition = RandomCondition();
            Name = $"{Condition} {WeaponType} (+{StrengthValue} strength)";

        }

        /// <summary>
        /// Generate and return a random weapon condition
        /// </summary>
        /// <returns>A string with the condition</returns>
        private string RandomCondition()
        {
            int percentage = Utilities.Random(0, 3);
            switch (percentage)
            {
                case 0: StrengthValue = 1; return "Rusty";
                case 1: StrengthValue = 2; return "Mediocre";
                default: StrengthValue = 3; return "Great";
            }
        }

        /// <summary>
        /// Generate and return a random weapon type
        /// </summary>
        /// <returns>A string with the weapon type</returns>
        private string RandomWeapon()
        {
            int percentage = Utilities.Random(0, 100);
            if (percentage < 33)
                return "Sword";
            else if (percentage < 67)
                return "Bow";
            else
                return "Axe";
        }

        /// <summary>
        /// Adds instance to <paramref name="player"/> inventory
        /// </summary>
        /// <param name="player">Specific players inventory</param>
        public override void Pickup(Player player)
        {
            base.Pickup(player);
            player.Strength += StrengthValue;
        }
    }
}
