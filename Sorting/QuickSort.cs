using System;

namespace Sorting
{
    class QuickSort<T>
        where T : IComparable
    {
        private int first = 0;
        private int last;
        public T[] Sort(T[] items)
        {
            last = items.Length - 1;
            return Sort(items, first, last);
        }

        private T[] Sort(T[] items, int first, int last)
        {
            if (first < last)
            {
                int q = Partition(items, first, last);
                Sort(items, first, q - 1);
                Sort(items, q + 1, last);
            }
            return items;
        }

        private int Partition(T[] items, int first, int last)
        {
            T x = items[last];
            int i = first - 1;
            for (int j = first; j < last; j++)
            {
                if ((items[j].CompareTo(x) < 0))
                {
                    i++;
                    Swap(items, i, j);
                }
            }
            Swap(items, i + 1, last);
            return i + 1;
        }

        private void Swap(T[] items, int v, int last)
        {
            T temp = items[v];
            items[v] = items[last];
            items[last] = temp;
        }
    }
}
