using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core.Characters
{
    public class Skeleton : Monster
    {
        /// <summary>
        /// Creates a weaker monster Skeleton
        /// </summary>
        /// <seealso cref="DungeonsOfDoom.Core.Characters.Monster" />
        public Skeleton() : base(15, "Skeleton", 7, 5, new string[3] { "......", ".....!!", "..." })
        {
        }
    }
}
