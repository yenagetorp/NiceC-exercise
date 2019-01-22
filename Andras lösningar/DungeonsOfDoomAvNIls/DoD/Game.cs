using DungeonsOfDoom.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoD
{
    class Game
    {
        public enum Directions
        {
            North,
            East,
            South,
            West
        }

        const int worldSizeX = 20, worldSizeY = 5;
        Room[,] world;
        const int roomLimit = 100;

        public void PlayGame()
        {
            CreateWorld();
        }

        // Sätt ett maximalt antal rum

        //Skapa ett rum i taget och slumpa en ny riktning

        //Fortsätt skapa rum i varje riktning

        //Avsluta när antal rum är = maximalt antal rum

        //Gå igenom alla rum och stäng dörrar som inte leder någonstans

        public void CreateWorld()
        {
            world = new Room[worldSizeX, worldSizeY];

            while (world.Length < roomLimit)
            {
                Room room = new DungeonRoom();


            }
        }

    }
}
