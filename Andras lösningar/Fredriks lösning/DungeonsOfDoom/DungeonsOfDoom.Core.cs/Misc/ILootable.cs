using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public interface ILootable
    {
        string Name { get; }
        void Pickup(Player player);
    }
}
