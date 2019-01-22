using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    public static class RandomUtil
    {
        static Random random = new Random();

        public static int GetRandomValue(int max)
        {
            return random.Next(1, max);
        }

        /// <summary>
        /// Checks if the random value is below a certain value.
        /// </summary>
        /// <param name="checkValue">Value to compare (0-99)</param>
        /// <returns>B</returns>
        public static bool CheckPercent(int checkValue)
        {
            return random.Next(0, 100) < checkValue;
        }

        /// <summary>
        /// Return random index to use on a collection
        /// </summary>
        /// <param name="numberOfItems">Number of items in collection</param>
        /// <returns></returns>
        public static int GetIndex(int numberOfItems)
        {
            return random.Next(0, numberOfItems);
        }
    }
}
