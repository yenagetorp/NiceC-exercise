using System;
using System.Collections.Generic;
using System.Text;

namespace Repetitionmed_H
{
    static class Utils
    {
        //* generic method *//
        // genom lägga till this, nu can vi nå generic methods utan Utils.!!!
       public static void GenericSelectionSort<T>(this T[] collection, Func<T, T, bool> lessThan)
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                int lowestElementValueIndex = i;
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (lessThan(collection[j], collection[lowestElementValueIndex])) //lessThan returns true!
                        lowestElementValueIndex = j;
                }

                T temp = collection[i];
                collection[i] = collection[lowestElementValueIndex];
                collection[lowestElementValueIndex] = temp;
            }
        }
    }
}
