using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] tab = { 5.4, 6.1, 2.0, 1.2, 5.5 };
            int[] tab= RandomData.RandomInt(0, 1000000, 10000);
            //int[] tab = { 1, 3, 4, 6, 12, 312, 5, 1213, 2, 54354, 2, 66, 444, 23, 6567, 2324, 12123, 36899, 7665, 7566, 75765, 444 };
            int[] tab2 = new int[tab.Length];
            tab.CopyTo(tab2,0);
            //Console.WriteLine("Ciąg wejściowy:");
            //foreach (int i in tab)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.Write("\n");

          
            Console.WriteLine("Sortowanie babelkowe");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Sort.BubbleSort(tab);
            //foreach (int i in tab)
            //{
            //    Console.Write(i + " ");
            //}
            Console.Write("\n");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Czas potrzebny na posortowanie: {elapsedMs}ms\n");

            Console.WriteLine("Sortowanie szybkie");
            watch = System.Diagnostics.Stopwatch.StartNew();
            Sort.QuickSort(tab2);
            //foreach (int i in tab2)
            //{
            //    Console.Write(i + " ");
            //}
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"\nCzas potrzebny na posortowanie: {elapsedMs}ms");
            Console.ReadKey();
        }
    }
}
