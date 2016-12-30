using System;

namespace Sorting
{
    /// <summary>
    /// Class used to sort simple type.
    /// </summary>
    /// <typeparam name="T">Sorting Type</typeparam>
    class BubbleSort<T>
        where T : IComparable
    {
        /// <summary>
        /// Method is using bubble sort.
        /// </summary>
        /// <param name="items">Items to sorted.</param>
        /// <returns></returns>
        internal T[] Sort(T[] items)
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
                        temp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = temp;
                        isSorted = false;
                    }
                }
            } while (!isSorted);
            return items;
        }
    }
}
