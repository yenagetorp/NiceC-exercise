using DungeonsOfDoom.Core.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Characters
{
    public class Player : Character
    {
        public Player(int health, int x, int y, string name) : base(health, name, 8, 10,new string[] { "Prepare to meet your doom!!", "Say hello to my little friend!", "Your time has come"})
        {
            BackPack = new List<ICollectable>();
            X = x;
            Y = y;
        }
        public List<ICollectable> BackPack { get; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
