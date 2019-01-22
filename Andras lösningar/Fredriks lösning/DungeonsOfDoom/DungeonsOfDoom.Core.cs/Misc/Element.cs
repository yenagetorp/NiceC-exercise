using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom.Core
{
    public class Element
    {
        public ConsoleColor Color { get; }

        /// <summary>
        /// Sets and elements color to be displayed in Console
        /// </summary>
        /// <param name="color">Color of the element</param>
        public Element(ConsoleColor color)
        {
            Color = color;
        }
    }
}
