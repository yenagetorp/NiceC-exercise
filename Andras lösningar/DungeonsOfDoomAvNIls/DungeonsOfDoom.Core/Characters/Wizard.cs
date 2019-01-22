using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace DungeonsOfDoom.Core.Characters
{
    public class Wizard : Monster
    {
        public List<Spell> Spells { get; set; }

        public Wizard(List<Spell> spells) : base(15, "Wizard", 7, 5, new string[3] { "......", ".....!!", "..." })
        {
            Spells = spells;
        }

        public override int Attack(Character opponent)
        {
            return Spells[RandomUtil.GetIndex(Spells.Count)].Cast(this, opponent);
        }
    }
}
