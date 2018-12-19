using System;
using System.Threading;

namespace SortAnalyser.Core.Abstract
{
    public abstract class Sorter
    {
        protected void Swap(int[] array, int itemA, int itemB)
        {
            int temp = array[itemA];
            array[itemA] = array[itemB];
            array[itemB] = temp;
        }

        protected void ShowIteration(int[] array)
        {
            Thread.Sleep(1000);
            ShowArray(array);
        }

        private void ShowArray(int[] array)
        {
            Console.Write("  ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
