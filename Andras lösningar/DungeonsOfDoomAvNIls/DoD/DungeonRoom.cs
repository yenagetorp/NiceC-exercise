using DungeonsOfDoom.Core;
using System;
using System.Collections.Generic;
using System.Text;
using static DoD.Game;

namespace DoD
{
    class DungeonRoom : Room
    {
        public List<Enum> Doors { get; set; }

        public DungeonRoom()
        {
            Doors = new List<Enum>();

        }
    }
}
