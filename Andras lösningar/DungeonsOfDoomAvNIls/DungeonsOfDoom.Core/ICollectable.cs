using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    /// <summary>
    /// Adds the possibility for an object to be added to backpack
    /// </summary>
    public interface ICollectable
    {
        string Name { get; }
    }
}
