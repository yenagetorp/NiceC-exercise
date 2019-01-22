using System;
using System.Collections.Generic;
using System.Text;

namespace DDUtils
{
    public static class Utilities
    {
        public static int Random(int min, int max)
        {
            Random rand = new Random();

            return rand.Next(min, max);
            
        }
    }
}
