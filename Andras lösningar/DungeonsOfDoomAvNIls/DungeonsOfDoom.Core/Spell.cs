using DungeonsOfDoom.Core.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public class Spell
    {
        public Spell(Func<Character, Character, int> cast)
        {
            Cast = cast;
        }

        public Func<Character, Character, int> Cast { get; set; }
    }
}
