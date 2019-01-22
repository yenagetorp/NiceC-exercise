using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint03
{
    static class Extension
    {
        public static void Print<T>(this IEnumerable<T> collectionToPrint, Func<T, string> convertItemToString)
        {
            foreach (var item in collectionToPrint)
            {
                Console.WriteLine(convertItemToString(item));
            }
        }
    }
}
