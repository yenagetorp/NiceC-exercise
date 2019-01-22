using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public class Orc : Monster
    {
        /// <summary>
        /// Creates a orc with basevalues
        /// </summary>
        public Orc() : base(12, "Orc", ConsoleColor.DarkGreen, 4)
        {
        }
    }
}
