using System;
using System.Collections;
using System.Collections.Generic;

namespace ListSimulator
{
    internal class Collection<T> : IEnumerable<T>, IEnumerator<T>, ICollection<T>
    {
        private T[] collection;
        private const int MinimumCapacity = 4;
        private int capacitySize;
        private int lastIndex = -1;
        private int iteratorCount = -1; // For foreach

        public T this[int index] // Indexer property!
        {
            get
            {
                if (index > lastIndex)
                    throw new IndexOutOfRangeException();

                return collection[index];
            }
            set
            {
                if (index > lastIndex)
                    throw new IndexOutOfRangeException();

                collection[index] = value;
            }
        }

        public Collection()
        {
            capacitySize = MinimumCapacity;
            collection = new T[capacitySize];
        }

        public Collection(int capacity)
        {
            capacitySize = capacity > MinimumCapacity ? capacity : MinimumCapacity;
            collection = new T[capacitySize];
        }

        /// <summary>
        /// Gets the number of elements contained in the MyList&lt;T&gt;
        /// </summary>
        public int Count => lastIndex + 1;

        public void Add(T item)
        {
            if (lastIndex + 1 == capacitySize)
            {
                capacitySize *= 2;
                Array.Resize(ref collection, capacitySize);
            }

            collection[++lastIndex] = item;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < lastIndex + 1; i++)
                if (collection[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index > lastIndex)
                throw new IndexOutOfRangeException();

            Array.ConstrainedCopy(collection, index + 1, collection, index, (lastIndex - index));
            lastIndex--;
            ReduceCapacity();
        }

        private void ReduceCapacity()
        {
            if ((capacitySize / 2 >= MinimumCapacity) && (lastIndex + 1) <= (capacitySize / 2))
            {
                capacitySize /= 2;
                Array.Resize(ref collection, (capacitySize));
            }
        }

        //private void DecreaseCollectionSize()
        //{
        //    capacitySize /= 2;
        //    T[] smallerCollection = new T[capacitySize];
        //    Array.Copy(collection, smallerCollection, lastIndex + 1);
        //    collection = smallerCollection;
        //}

        //private void IncreaseCollectionSize()
        //{
        //    capacitySize *= 2;
        //    T[] largerCollection = new T[capacitySize];
        //    Array.Copy(collection, largerCollection, lastIndex + 1);
        //    collection = largerCollection;
        //}

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public T Current => collection[iteratorCount];

        object IEnumerator.Current => collection[iteratorCount];

        public bool MoveNext()
        {
            iteratorCount++;
            return iteratorCount <= lastIndex;
        }

        public void Reset()
        {
            iteratorCount = -1;
        }

        public void Dispose()
        {
            Reset();
        }

        public void Clear()
        {
            lastIndex = -1;
            ReduceCapacity();
        }

        public bool Contains(T item)
        {
            bool contains = false;

            for (int i = 0; i <= lastIndex; i++)
            {
                contains = collection[i].Equals(item);

                if (contains)
                    break;
            }

            return contains;
        }

        public T Find(Predicate<T> match)          
        {
            T element = default(T);

            for (int i = 0; i <= lastIndex; i++)
                if (match(collection[i]))
                {
                    element = collection[i];
                    break;
                }

            return element;
        }
    }
}
