using System;

namespace ListSimulator
{
    internal interface ICollection<T>
    {
        T this[int index] { get; set; }
       

        int Count { get; }

        void Add(T item);
        bool Remove(T item);
        void RemoveAt(int index);

        void Clear(); // Extra exercise!
        bool Contains(T item); // Extra exercise!
        T Find(Predicate<T> match);  // Extra exercise!
    }
}