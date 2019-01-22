using DDUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public class Chest : Item, IAttackable, ILootable
    {
        Item[] chestItems;
        public int Health { get; set; } = 3;
        public int MaxHealth { get; set; } = 3;
        public int Strength { get; set; } = 0;

        /// <summary>
        /// Initialize Chest containing a random amount of <c>Item</c>
        /// </summary>
        public Chest() : base("Chest")
        {
            chestItems = new Item[Utilities.Random(1, 4)];

            for (int i = 0; i < chestItems.Length; i++)
            {
                int percentage = Utilities.Random(0, 100);
                if (percentage < 50)
                    chestItems[i] = new Weapon();
                else
                    chestItems[i] = new Consumable();
            }
        }

        /// <summary>
        /// Adds instance to <paramref name="player"/> inventory
        /// </summary>
        /// <param name="player">Specific players inventory</param>
        public override void Pickup(Player player)
        {
            foreach (var item in chestItems)
            {
                item.Pickup(player);
            }
        }

        /// <summary>
        /// Attack and open this Chest
        /// </summary>
        /// <param name="opponent">Player opening/fighting this Chest</param>
        /// <returns>FightStats instance with declared EventMessage</returns>
        public FightStats Fight(IAttackable opponent)
        {
            Health--;
            if (Health > 0)
                return new FightStats(Name, opponent.Name, "Picking up lock...");

            return new FightStats(Name, opponent.Name, "You opened the chest!");
        }
    }
}
