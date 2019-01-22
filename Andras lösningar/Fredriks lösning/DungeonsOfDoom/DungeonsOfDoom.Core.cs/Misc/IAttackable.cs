using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public interface IAttackable
    {
        //string Fight(IAttackable opponent);
        int Health { get; set; }
        int MaxHealth { get; set; }
        string Name { get; }
        int Strength { get; set; }
    }
}
