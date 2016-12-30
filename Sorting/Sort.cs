using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Sort
    {

        public static void BubbleSort<T>(T[] items)
            where T : struct, IComparable
        {
            T temp;// = new T();
            bool isSorted = false;
            do
            {
                isSorted = true;
                for (int i = 0; i < items.Length - 1; i++)
                {
                    if (items[i].CompareTo(items[i + 1]) > 0)
                    {
                        Swap(items, i, i + 1);
                        isSorted = false;
                    }
                }
            } while (!isSorted);
        }

        public static void QuickSort<T>(T[] items)
           where T : struct, IComparable
        {
            int first = 0;
            int last = items.Length - 1;
            QuickSort(items, first, last);
        }

        private static void QuickSort<T>(T[] items, int first, int last)
            where T : struct, IComparable
        {
            if (first < last)
            {
                int q = Partition(items, first, last);
                QuickSort(items, first, q - 1);
                QuickSort(items, q + 1, last);
            }
        }

        private static int Partition<T>(T[] items, int first, int last)
            where T : struct, IComparable
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

        private static void Swap<T>(T[] items, int v, int last)
        {
            T temp = items[v];
            items[v] = items[last];
            items[last] = temp;
        }

    }
}
