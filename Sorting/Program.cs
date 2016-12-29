using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] tab = { 5.4, 6.1, 2.0, 1.2, 5.5 };
            int[] tab = { 1, 3, 4, 6, 12, 312, 5, 1213, 2, 54354, 2, 66, 444, 23, 6567, 2324, 12123, 36899, 7665, 7566, 75765, 444 };
            BubbleSort<int> bubbleSort = new BubbleSort<int>();
            bubbleSort.Sort(tab);
            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
